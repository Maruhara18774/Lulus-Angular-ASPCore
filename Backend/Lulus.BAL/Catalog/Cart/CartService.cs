using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.ViewModels.Cart;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Cart
{
    public class CartService: ICartService
    {
        private readonly LulusDBContext _context;
        private readonly SignInManager<User> _signInManager;
        public CartService(LulusDBContext context, SignInManager<User> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        public async Task<CartViewModel> Get(string token)
        {
            var userID = GetUserID(token);
            var cart = await _context.Orders.Where(x => x.UserID == userID && x.Status == Data.Enums.OrderStatus.New).FirstOrDefaultAsync();
            if(cart == null)
            {
                cart = await CreateNewCart(userID);
                return new CartViewModel()
                {
                    ID = cart.ID,
                    UserID = userID,
                    Total = cart.Total,
                    LineCount = 0,
                    Items = new List<CartItemViewModel>()
                };
            }
            var cartDetails = await _context.OrderDetails.Where(x => x.OrderID == cart.ID).ToListAsync();
            var result = new CartViewModel()
            {
                ID = cart.ID,
                UserID = userID,
                Total = cart.Total,
                LineCount = cartDetails.Count,
                Items = new List<CartItemViewModel>()
            };
            foreach(var item in cartDetails)
            {
                var line = await _context.ProductLines.Where(x => x.ID == item.ProductLineID).FirstOrDefaultAsync();
                result.Items.Add(new CartItemViewModel()
                {
                    ID = item.ID,
                    LineID = item.ProductLineID,
                    Quantity = item.Quantity,
                    Total = item.Total,
                    Color = await _context.Textures.Where(x => x.ID == line.TextureID).Select(x => x.Name).FirstOrDefaultAsync(),
                    Name = await _context.Products.Where(x => x.ID == line.ProductID).Select(x => x.Name).FirstOrDefaultAsync(),
                    Price = await _context.Products.Where(x => x.ID == line.ProductID).Select(x => x.Price).FirstOrDefaultAsync()
                });
            }
            return result;
        }
        Guid GetUserID(string token)
        {
            var stream = token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = jsonToken as JwtSecurityToken;

            return new Guid(tokenS.Claims.First(claim => claim.Type == ClaimTypes.PrimarySid.ToString()).Value);
        }
        async Task<Order> CreateNewCart(Guid userID)
        {
            _context.Orders.Add(new Order()
            {
                UserID = userID,
                Status = Data.Enums.OrderStatus.New,
                Total = 0,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
            await _context.SaveChangesAsync();
            return await _context.Orders.Where(x => x.UserID == userID && x.Status == Data.Enums.OrderStatus.New).FirstOrDefaultAsync();
        }

        public async Task<bool> Add(Add2CartRequest request)
        {
            var userID = GetUserID(request.token);
            var cart = await _context.Orders.Where(x => x.UserID == userID && x.Status == Data.Enums.OrderStatus.New).FirstOrDefaultAsync();
            if(cart == null)
            {
                cart = await CreateNewCart(userID);
            }
            var cartItem = await _context.OrderDetails.Where(x => x.OrderID == cart.ID && x.ProductLineID == request.LineID).FirstOrDefaultAsync();
            var quantity = request.Quantity > 0 ? request.Quantity : 1;
            var line = await _context.ProductLines.Where(x => x.ID == request.LineID).FirstOrDefaultAsync();
            var price = await _context.Products.Where(x => x.ID == line.ProductID).Select(x => x.Price).FirstOrDefaultAsync();
            if (cartItem == null)
            {
                _context.OrderDetails.Add(new OrderDetail()
                {
                    Quantity = quantity,
                    Total = quantity * price,
                    OrderID = cart.ID,
                    ProductLineID = request.LineID,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                });
                cart.Total += quantity * price;
                cart.Updated = DateTime.Now;
                await _context.SaveChangesAsync();
                return true;
            }
            cartItem.Quantity += request.Quantity;
            cartItem.Updated = DateTime.Now;
            cartItem.Total += quantity * price;
            cart.Total += quantity * price;
            cart.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Update(Add2CartRequest request)
        {
            var userID = GetUserID(request.token);
            var cart = await _context.Orders.Where(x => x.UserID == userID && x.Status == Data.Enums.OrderStatus.New).FirstOrDefaultAsync();
            if (cart == null)
            {
                cart = await CreateNewCart(userID);
            }
            var cartItem = await _context.OrderDetails.Where(x => x.OrderID == cart.ID && x.ProductLineID == request.LineID).FirstOrDefaultAsync();
            var quantity = request.Quantity > 0 ? request.Quantity : 1;
            var line = await _context.ProductLines.Where(x => x.ID == request.LineID).FirstOrDefaultAsync();
            var price = await _context.Products.Where(x => x.ID == line.ProductID).Select(x => x.Price).FirstOrDefaultAsync();
            if (cartItem == null)
            {
                return false;
            }
            var finalTotal = cart.Total - (cartItem.Total);
            cartItem.Quantity = request.Quantity;
            cartItem.Updated = DateTime.Now;
            cartItem.Total = finalTotal + (quantity * price);
            cart.Total += quantity * price;
            cart.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var cartItem = await _context.OrderDetails.Where(x => x.ID == id).FirstOrDefaultAsync();
            var cart = await _context.Orders.Where(x => x.ID == cartItem.OrderID).FirstOrDefaultAsync();
            cart.Total -= cartItem.Total;
            _context.OrderDetails.Remove(cartItem);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Clear(string token)
        {
            var userID = GetUserID(token);
            var cart = await _context.Orders.Where(x => x.UserID == userID && x.Status == Data.Enums.OrderStatus.New).FirstOrDefaultAsync();
            if (cart == null)
            {
                cart = await CreateNewCart(userID);
            }
            var items = await _context.OrderDetails.Where(x => x.OrderID == cart.ID).ToListAsync();
            foreach(var item in items)
            {
                _context.OrderDetails.Remove(item);
            }
            cart.Total = 0;
            cart.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<string> Checkout(CheckoutRequest request)
        {
            var userID = GetUserID(request.Token);
            var cart = await _context.Orders.Where(x => x.UserID == userID && x.Status == Data.Enums.OrderStatus.New).FirstOrDefaultAsync();
            if (cart == null)
            {
                cart = await CreateNewCart(userID);
            }
            var user = await _context.Users.Where(x => x.Id == userID).FirstOrDefaultAsync();
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, false);
            if (!result.Succeeded) return "Wrong password";
            var userAddress = await _context.Addresses.Where(x => x.UserID == userID).FirstOrDefaultAsync();
            if(userAddress == null)
            {
                userAddress = await CreateNewAddress(userID);
            }
            userAddress.Fullname = request.Fullname;
            userAddress.ProvinceID = request.ProvinceID;
            userAddress.Phone = request.Phone == null || request.Phone == "" ? user.PhoneNumber : request.Phone;
            cart.Status = Data.Enums.OrderStatus.Accepted;
            cart.Updated = DateTime.Now;
            await _context.SaveChangesAsync();
            return "";
        }
        public async Task<Address> CreateNewAddress(Guid userID)
        {
            _context.Addresses.Add(new Address()
            {
                UserID = userID, 
                Fullname = "",
                ProvinceID = (await _context.Provinces.FirstOrDefaultAsync()).ID,
                Phone = ""
            });
            await _context.SaveChangesAsync();
            return await _context.Addresses.Where(x => x.UserID == userID).FirstOrDefaultAsync();
        }
    }
}
