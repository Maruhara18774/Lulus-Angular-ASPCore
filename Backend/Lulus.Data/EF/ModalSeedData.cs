using Lulus.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.EF
{
    public static class ModalSeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            AddUsers(modelBuilder);
            AddCategories(modelBuilder);
            AddCountry(modelBuilder);
            AddDesigner(modelBuilder);
            AddOccation(modelBuilder);
            AddTexture(modelBuilder);
            AddTexture2(modelBuilder);

            AddCity(modelBuilder);
            AddFavoriteDesigner(modelBuilder);
            AddProduct(modelBuilder);
            AddSubcategory(modelBuilder);

            AddProductLine(modelBuilder);
            AddProductLine2(modelBuilder);
            AddProductImage(modelBuilder);
            AddProductImage2(modelBuilder);
            AddProductImage3(modelBuilder);
            AddProductOccation(modelBuilder);
            AddProductSubcategory(modelBuilder);

            AddProvince(modelBuilder);
        }
        // Non-relationship
        static void AddUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    Email = "user@shop.com",
                    NormalizedEmail = "USER@SHOP.COM",
                    UserName = "user",
                    NormalizedUserName = "USER",
                    PhoneNumber = "0125454545",
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!")
                },
                new User()
                {
                    Id = new Guid("50892AC9-EBE0-4C8D-F28E-08D9638E12DC"),
                    Email = "user-bak@shop.com",
                    NormalizedEmail = "USER-BAK@SHOP.COM",
                    UserName = "user-bak",
                    NormalizedUserName = "USER-BAK",
                    PhoneNumber = "0125454546",
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!")
                },
                new User()
                {
                    Id = new Guid("170CA4BC-EF9F-4DE7-AE96-08D962DAD25F"),
                    Email = "admin@shop.com",
                    NormalizedEmail = "ADMIN@SHOP.COM",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PhoneNumber = "0323265665",
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!")
                },
                new User()
                {
                    Id = new Guid("0DD37C3C-4694-429E-623B-08D962DBDED7"),
                    Email = "admin-bak@shop.com",
                    NormalizedEmail = "ADMIN-BAK@SHOP.COM",
                    UserName = "admin-bak",
                    NormalizedUserName = "ADMIN-BAK",
                    PhoneNumber = "0323265666",
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!")
                }
                );
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>
                {
                    Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<Guid>
                {
                    Id = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D"),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    RoleId = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D"),
                },
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("50892AC9-EBE0-4C8D-F28E-08D9638E12DC"),
                    RoleId = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D"),
                },
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("170CA4BC-EF9F-4DE7-AE96-08D962DAD25F"),
                    RoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                },
                new IdentityUserRole<Guid>
                {
                    UserId = new Guid("0DD37C3C-4694-429E-623B-08D962DBDED7"),
                    RoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                }
                );
        }
        static void AddCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1,
                    Name = "Activewear"
                },
                new Category()
                {
                    ID = 2,
                    Name = "Denim"
                },
                new Category()
                {
                    ID = 3,
                    Name = "Dresses"
                },
                new Category()
                {
                    ID = 4,
                    Name = "Jackets & Coats"
                },
                new Category()
                {
                    ID = 5,
                    Name = "Jumpsuits"
                },
                new Category()
                {
                    ID = 6,
                    Name = "Leather"
                },
                new Category()
                {
                    ID = 7,
                    Name = "Lingerie & Sleepwear"
                },
                new Category()
                {
                    ID = 8,
                    Name = "Loungewear"
                },
                new Category()
                {
                    ID = 9,
                    Name = "Pants"
                },
                new Category()
                {
                    ID = 10,
                    Name = "Rompers"
                },
                new Category()
                {
                    ID = 11,
                    Name = "Shorts"
                },
                new Category()
                {
                    ID = 12,
                    Name = "Skirts"
                },
                new Category()
                {
                    ID = 13,
                    Name = "Sweaters & Knits"
                },
                new Category()
                {
                    ID = 14,
                    Name = "Swimsuits & Cover-Ups"
                },
                new Category()
                {
                    ID = 15,
                    Name = "Tops"
                }
                );
        }
        static void AddCountry(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    ID = 1,
                    Name = "Vietnam"
                },
                new Country()
                {
                    ID = 2,
                    Name = "China"
                },
                new Country()
                {
                    ID = 3,
                    Name = "America"
                }
                );
        }
        static void AddDesigner(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Desinger>().HasData(
                new Desinger()
                {
                    ID = 1,
                    Name = "ELLIATT"
                },
                new Desinger()
                {
                    ID = 2,
                    Name = "Sabina Musayev"
                },
                new Desinger()
                {
                    ID = 3,
                    Name = "krisa"
                },
                new Desinger()
                {
                    ID = 4,
                    Name = "Michael Costello"
                },
                new Desinger()
                {
                    ID = 5,
                    Name = "AFRM"
                },
                new Desinger()
                {
                    ID = 6,
                    Name = "Amanda Uprichard"
                },
                new Desinger()
                {
                    ID = 7,
                    Name = "SOLACE London"
                },
                new Desinger()
                {
                    ID = 8,
                    Name = "retrofete"
                },
                new Desinger()
                {
                    ID = 9,
                    Name = "ASTR the Label"
                },
                new Desinger()
                {
                    ID = 10,
                    Name = "ALLSAINTS"
                },
                new Desinger()
                {
                    ID = 11,
                    Name = "LAMARQUE"
                },
                new Desinger()
                {
                    ID = 12,
                    Name = "Helmut Lang"
                },
                new Desinger()
                {
                    ID = 13,
                    Name = "LPA"
                },
                new Desinger()
                {
                    ID = 14,
                    Name = "SPRWMN"
                },
                new Desinger()
                {
                    ID = 15,
                    Name = "Understated Leather"
                }
                );
        }
        static void AddOccation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Occation>().HasData(
                new Occation()
                {
                    ID = 1,
                    Name = "To A Special Event"
                },
                new Occation()
                {
                    ID = 2,
                    Name = "On Vacation"
                },
                new Occation()
                {
                    ID = 3,
                    Name = "For A Night Out"
                },
                new Occation()
                {
                    ID = 4,
                    Name = "On The Weekend"
                }
                );
        }
        static void AddTexture(ModelBuilder modelBuilder)
        {
            string baseURL = "Images/Texture/";
            modelBuilder.Entity<Texture>().HasData(
                new Texture()
                {
                    ID = 1,
                    Name = "Lilac",
                    Image = baseURL + "lilac.webp"
                },
                new Texture()
                {
                    ID = 2,
                    Name = "Marigold",
                    Image = baseURL + "marigold.webp"
                },
                new Texture()
                {
                    ID = 3,
                    Name = "Blue",
                    Image = baseURL + "blue.webp"
                },
                new Texture()
                {
                    ID = 4,
                    Name = "Blush",
                    Image = baseURL + "blush.webp"
                },
                new Texture()
                {
                    ID = 5,
                    Name = "Multicolor Blue",
                    Image = baseURL + "multicolor-blue.webp"
                },
                new Texture()
                {
                    ID = 6,
                    Name = "Black",
                    Image = baseURL + "black.webp"
                },
                new Texture()
                {
                    ID = 7,
                    Name = "Rosa",
                    Image = baseURL + "rosa.webp"
                },
                new Texture()
                {
                    ID = 8,
                    Name = "Candy",
                    Image = baseURL + "candy.webp"
                },
                new Texture()
                {
                    ID = 9,
                    Name = "Taupe",
                    Image = baseURL + "taupe.webp"
                },
                new Texture()
                {
                    ID = 10,
                    Name = "Baby Blue",
                    Image = baseURL + "baby-blue.webp"
                },
                new Texture()
                {
                    ID = 11,
                    Name = "Abstract Neon Dot",
                    Image = baseURL + "abstract-neon-dot.webp"
                },
                new Texture()
                {
                    ID = 12,
                    Name = "Multi Watercolor",
                    Image = baseURL + "multi-watercolor.webp"
                },
                new Texture()
                {
                    ID = 13,
                    Name = "White Sequin",
                    Image = baseURL + "white-sequin.webp"
                },
                new Texture()
                {
                    ID = 14,
                    Name = "Black Sequin",
                    Image = baseURL + "black-sequin.webp"
                },
                new Texture()
                {
                    ID = 15,
                    Name = "Cream",
                    Image = baseURL + "cream.webp"
                },
                new Texture()
                {
                    ID = 16,
                    Name = "Pink",
                    Image = baseURL + "pink.webp"
                },
                new Texture()
                {
                    ID = 17,
                    Name = "Green",
                    Image = baseURL + "green.webp"
                },
                new Texture()
                {
                    ID = 18,
                    Name = "White",
                    Image = baseURL + "white.png"
                },
                new Texture()
                {
                    ID = 19,
                    Name = "Olive",
                    Image = baseURL + "olive.webp"
                },
                new Texture()
                {
                    ID = 20,
                    Name = "Pink Orchid",
                    Image = baseURL + "pink-orchid.webp"
                },
                new Texture()
                {
                    ID = 21,
                    Name = "Moonglow White",
                    Image = baseURL + "moonglow-white.webp"
                },
                new Texture()
                {
                    ID = 22,
                    Name = "Taffy Pink",
                    Image = baseURL + "taffy-pink.webp"
                },
                new Texture()
                {
                    ID = 23,
                    Name = "Acid Wash Black",
                    Image = baseURL + "acid-wash-black.webp"
                },
                new Texture()
                {
                    ID = 24,
                    Name = "Tan",
                    Image = baseURL + "tan.webp"
                },
                new Texture()
                {
                    ID = 25,
                    Name = "Red",
                    Image = baseURL + "red.webp"
                },
                new Texture()
                {
                    ID = 26,
                    Name = "Faded Jean",
                    Image = baseURL + "faded-jean.webp"
                },
                new Texture()
                {
                    ID = 27,
                    Name = "Bone",
                    Image = baseURL + "bone.webp"
                },
                new Texture()
                {
                    ID = 28,
                    Name = "Off White",
                    Image = baseURL + "off-white.webp"
                },
                new Texture()
                {
                    ID = 29,
                    Name = "Dust",
                    Image = baseURL + "dust.webp"
                },
                new Texture()
                {
                    ID = 30,
                    Name = "Dusty Pink",
                    Image = baseURL + "dusty-pink.webp"
                },
                new Texture()
                {
                    ID = 31,
                    Name = "Sand",
                    Image = baseURL + "sand.webp"
                },
                new Texture()
                {
                    ID = 32,
                    Name = "Seseme",
                    Image = baseURL + "seseme.webp"
                }
                );
        }
        static void AddTexture2(ModelBuilder modelBuilder)
        {
            string baseURL = "Images/Texture/";
            //modelBuilder.Entity<Texture>().HasData();
        }
        // 1-Relationship
        static void AddCity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    ID = 1,
                    Name = "Can Tho",
                    CountryID = 1
                },
                new City()
                {
                    ID = 2,
                    Name = "Da Nang",
                    CountryID = 1
                },
                new City()
                {
                    ID = 3,
                    Name = "Hai Phong",
                    CountryID = 1
                },
                new City()
                {
                    ID = 4,
                    Name = "Hanoi",
                    CountryID = 1
                },
                new City()
                {
                    ID = 5,
                    Name = "Ho Chi Minh",
                    CountryID = 1
                },
                new City()
                {
                    ID = 6,
                    Name = "Hong Kong",
                    CountryID = 2
                },
                new City()
                {
                    ID = 7,
                    Name = "Ma Cau",
                    CountryID = 2
                },
                new City()
                {
                    ID = 8,
                    Name = "Beijing",
                    CountryID = 2
                },
                new City()
                {
                    ID = 9,
                    Name = "Shanghai",
                    CountryID = 2
                },
                new City()
                {
                    ID = 10,
                    Name = "New York",
                    CountryID = 3
                },
                new City()
                {
                    ID = 11,
                    Name = "Los Angeles",
                    CountryID = 3
                }
                );
        }
        static void AddFavoriteDesigner(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteDesigner>().HasData(
                new FavoriteDesigner()
                {
                    ID = 1,
                    UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    DesignerID = 2
                },
                new FavoriteDesigner()
                {
                    ID = 2,
                    UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    DesignerID = 3
                },
                new FavoriteDesigner()
                {
                    ID = 3,
                    UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    DesignerID = 5
                },
                new FavoriteDesigner()
                {
                    ID = 4,
                    UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    DesignerID = 7
                },
                new FavoriteDesigner()
                {
                    ID = 5,
                    UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                    DesignerID = 9
                }
                );
        }
        static void AddProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ID = 1,
                    Name = "X REVOLVE Cassini Dress",
                    Price = 187,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 1,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 2,
                    Name = "X REVOLVE Carry Mini Dress",
                    Price = 232,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 2,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Mini,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 3,
                    Name = "Drape Button Front Mini",
                    Price = 216,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 3,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.ShortSleeve
                },
                new Product()
                {
                    ID = 4,
                    Name = "Jake Gown",
                    Price = 198,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 4,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 5,
                    Name = "Shailene Dress",
                    Price = 88,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 5,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 6,
                    Name = "x REVOLVE Samba Gown",
                    Price = 290,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 6,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.Tank
                },
                new Product()
                {
                    ID = 7,
                    Name = "Elina Mini Dress",
                    Price = 527,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 7,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.Tank
                },
                new Product()
                {
                    ID = 8,
                    Name = "Margot Dress",
                    Price = 895,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 8,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Mini,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 9,
                    Name = "Valinda Dress",
                    Price = 128,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 9,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 10,
                    Name = "Katya Dress",
                    Price = 795,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 3,
                    DesignerID = 8,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 11,
                    Name = "Morgan Biker Jacket",
                    Price = 659,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 10,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Mini,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 12,
                    Name = "x REVOLVE Dylan Jacket",
                    Price = 295,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 11,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 13,
                    Name = "Donna Jacket",
                    Price = 546,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 11,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 14,
                    Name = "Slit Leather Pant",
                    Price = 995,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 12,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 15,
                    Name = "Carmella Leather Corset",
                    Price = 209,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 13,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 16,
                    Name = "Ilonna Dress",
                    Price = 693,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 11,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 17,
                    Name = "Ankle Legging With Zipper",
                    Price = 1250,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 14,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 18,
                    Name = "X REVOLVE Paris Texas Full Skirt",
                    Price = 242,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 15,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 19,
                    Name = "X REVOLVE Paris Texas Full Skirt",
                    Price = 242,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 11,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 20,
                    Name = "Davina Leather Corset",
                    Price = 319,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 2,
                    DesignerID = 11,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                }
                );
        }
        static void AddSubcategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory()
                {
                    ID = 1,
                    Name = "Cocktail"
                },
                new Subcategory()
                {
                    ID = 2,
                    Name = "One Shoulder"
                },
                new Subcategory()
                {
                    ID = 3,
                    Name = "Bohemian"
                },
                new Subcategory()
                {
                    ID = 4,
                    Name = "Bodycon"
                },
                new Subcategory()
                {
                    ID = 5,
                    Name = "Denim"
                },
                new Subcategory()
                {
                    ID = 6,
                    Name = "Wrap"
                },
                new Subcategory()
                {
                    ID = 7,
                    Name = "Floral"
                },
                new Subcategory()
                {
                    ID = 8,
                    Name = "Gingham"
                },
                new Subcategory()
                {
                    ID = 9,
                    Name = "Sundresses"
                }
                );
        } 

        // 2-Relationship
        static void AddProductLine(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductLine>().HasData(
                new ProductLine()
                {
                    ID = 1,
                    TextureID = 1,
                    ProductID = 1,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 2,
                    TextureID = 2,
                    ProductID = 1,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 3,
                    TextureID = 3,
                    ProductID = 1,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 4,
                    TextureID = 4,
                    ProductID = 2,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 5,
                    TextureID = 5,
                    ProductID = 2,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 6,
                    TextureID = 6,
                    ProductID = 3,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 7,
                    TextureID = 7,
                    ProductID = 3,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 8,
                    TextureID = 8,
                    ProductID = 3,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 9,
                    TextureID = 9,
                    ProductID = 4,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 10,
                    TextureID = 10,
                    ProductID = 4,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 11,
                    TextureID = 11,
                    ProductID = 5,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 12,
                    TextureID = 12,
                    ProductID = 5,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 13,
                    TextureID = 13,
                    ProductID = 6,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 14,
                    TextureID = 14,
                    ProductID = 6,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 15,
                    TextureID = 15,
                    ProductID = 7,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 16,
                    TextureID = 16,
                    ProductID = 7,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 17,
                    TextureID = 17,
                    ProductID = 8,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 18,
                    TextureID = 18,
                    ProductID = 8,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 19,
                    TextureID = 19,
                    ProductID = 9,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 20,
                    TextureID = 20,
                    ProductID = 9,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 21,
                    TextureID = 21,
                    ProductID = 10,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 22,
                    TextureID = 22,
                    ProductID = 10,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 23,
                    TextureID = 6,
                    ProductID = 11,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 24,
                    TextureID = 6,
                    ProductID = 12,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 25,
                    TextureID = 23,
                    ProductID = 12,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 26,
                    TextureID = 18,
                    ProductID = 12,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 27,
                    TextureID = 24,
                    ProductID = 12,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 28,
                    TextureID = 25,
                    ProductID = 12,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 29,
                    TextureID = 6,
                    ProductID = 13,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 30,
                    TextureID = 18,
                    ProductID = 13,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 31,
                    TextureID = 26,
                    ProductID = 13,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 32,
                    TextureID = 6,
                    ProductID = 14,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 33,
                    TextureID = 15,
                    ProductID = 15,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 34,
                    TextureID = 6,
                    ProductID = 16,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 35,
                    TextureID = 27,
                    ProductID = 16,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 36,
                    TextureID = 28,
                    ProductID = 17,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 37,
                    TextureID = 6,
                    ProductID = 17,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 38,
                    TextureID = 29,
                    ProductID = 18,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 39,
                    TextureID = 30,
                    ProductID = 18,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 40,
                    TextureID = 31,
                    ProductID = 19,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 41,
                    TextureID = 6,
                    ProductID = 19,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 42,
                    TextureID = 6,
                    ProductID = 20,
                    Quantity = 99
                },
                new ProductLine()
                {
                    ID = 43,
                    TextureID = 32,
                    ProductID = 20,
                    Quantity = 99
                }
                );
        }
        static void AddProductLine2(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductLine>().HasData();
        }
        static void AddProductImage(ModelBuilder modelBuilder)
        {
            string baseURL = "Images/Product/";
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    ID = 1,
                    ProductLineID = 1,
                    Image = baseURL + "Product1/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 2,
                    ProductLineID = 1,
                    Image = baseURL + "Product1/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 3,
                    ProductLineID = 1,
                    Image = baseURL + "Product1/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 4,
                    ProductLineID = 2,
                    Image = baseURL + "Product1/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 5,
                    ProductLineID = 2,
                    Image = baseURL + "Product1/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 6,
                    ProductLineID = 2,
                    Image = baseURL + "Product1/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 7,
                    ProductLineID = 3,
                    Image = baseURL + "Product1/Line3/1.webp"
                },
                new ProductImage()
                {
                    ID = 8,
                    ProductLineID = 3,
                    Image = baseURL + "Product1/Line3/2.webp"
                },
                new ProductImage()
                {
                    ID = 9,
                    ProductLineID = 3,
                    Image = baseURL + "Product1/Line3/3.webp"
                },
                new ProductImage()
                {
                    ID = 10,
                    ProductLineID = 4,
                    Image = baseURL + "Product2/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 11,
                    ProductLineID = 4,
                    Image = baseURL + "Product2/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 12,
                    ProductLineID = 4,
                    Image = baseURL + "Product2/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 13,
                    ProductLineID = 4,
                    Image = baseURL + "Product2/Line1/4.jpg"
                },
                new ProductImage()
                {
                    ID = 14,
                    ProductLineID = 5,
                    Image = baseURL + "Product2/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 15,
                    ProductLineID = 5,
                    Image = baseURL + "Product2/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 16,
                    ProductLineID = 5,
                    Image = baseURL + "Product2/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 17,
                    ProductLineID = 5,
                    Image = baseURL + "Product2/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 18,
                    ProductLineID = 6,
                    Image = baseURL + "Product3/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 19,
                    ProductLineID = 6,
                    Image = baseURL + "Product3/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 20,
                    ProductLineID = 6,
                    Image = baseURL + "Product3/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 21,
                    ProductLineID = 7,
                    Image = baseURL + "Product3/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 22,
                    ProductLineID = 7,
                    Image = baseURL + "Product3/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 23,
                    ProductLineID = 7,
                    Image = baseURL + "Product3/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 24,
                    ProductLineID = 8,
                    Image = baseURL + "Product3/Line3/1.webp"
                },
                new ProductImage()
                {
                    ID = 25,
                    ProductLineID = 8,
                    Image = baseURL + "Product3/Line3/2.webp"
                },
                new ProductImage()
                {
                    ID = 26,
                    ProductLineID = 8,
                    Image = baseURL + "Product3/Line3/3.webp"
                },
                new ProductImage()
                {
                    ID = 27,
                    ProductLineID = 9,
                    Image = baseURL + "Product4/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 28,
                    ProductLineID = 9,
                    Image = baseURL + "Product4/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 29,
                    ProductLineID = 9,
                    Image = baseURL + "Product4/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 30,
                    ProductLineID = 10,
                    Image = baseURL + "Product4/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 31,
                    ProductLineID = 10,
                    Image = baseURL + "Product4/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 32,
                    ProductLineID = 10,
                    Image = baseURL + "Product4/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 33,
                    ProductLineID = 11,
                    Image = baseURL + "Product5/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 34,
                    ProductLineID = 11,
                    Image = baseURL + "Product5/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 35,
                    ProductLineID = 11,
                    Image = baseURL + "Product5/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 36,
                    ProductLineID = 12,
                    Image = baseURL + "Product5/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 37,
                    ProductLineID = 12,
                    Image = baseURL + "Product5/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 38,
                    ProductLineID = 12,
                    Image = baseURL + "Product5/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 39,
                    ProductLineID = 13,
                    Image = baseURL + "Product6/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 40,
                    ProductLineID = 13,
                    Image = baseURL + "Product6/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 41,
                    ProductLineID = 13,
                    Image = baseURL + "Product6/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 42,
                    ProductLineID = 13,
                    Image = baseURL + "Product6/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 43,
                    ProductLineID = 13,
                    Image = baseURL + "Product6/Line1/5.webp"
                },
                new ProductImage()
                {
                    ID = 44,
                    ProductLineID = 14,
                    Image = baseURL + "Product6/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 45,
                    ProductLineID = 14,
                    Image = baseURL + "Product6/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 46,
                    ProductLineID = 14,
                    Image = baseURL + "Product6/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 47,
                    ProductLineID = 14,
                    Image = baseURL + "Product6/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 48,
                    ProductLineID = 15,
                    Image = baseURL + "Product7/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 49,
                    ProductLineID = 15,
                    Image = baseURL + "Product7/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 50,
                    ProductLineID = 15,
                    Image = baseURL + "Product7/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 51,
                    ProductLineID = 16,
                    Image = baseURL + "Product7/Line2/1.jpg"
                },
                new ProductImage()
                {
                    ID = 52,
                    ProductLineID = 16,
                    Image = baseURL + "Product7/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 53,
                    ProductLineID = 16,
                    Image = baseURL + "Product7/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 54,
                    ProductLineID = 17,
                    Image = baseURL + "Product8/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 55,
                    ProductLineID = 17,
                    Image = baseURL + "Product8/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 56,
                    ProductLineID = 17,
                    Image = baseURL + "Product8/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 57,
                    ProductLineID = 17,
                    Image = baseURL + "Product8/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 58,
                    ProductLineID = 18,
                    Image = baseURL + "Product8/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 59,
                    ProductLineID = 18,
                    Image = baseURL + "Product8/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 60,
                    ProductLineID = 18,
                    Image = baseURL + "Product8/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 61,
                    ProductLineID = 18,
                    Image = baseURL + "Product8/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 62,
                    ProductLineID = 18,
                    Image = baseURL + "Product8/Line2/5.jpg"
                },
                new ProductImage()
                {
                    ID = 63,
                    ProductLineID = 19,
                    Image = baseURL + "Product9/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 64,
                    ProductLineID = 19,
                    Image = baseURL + "Product9/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 65,
                    ProductLineID = 19,
                    Image = baseURL + "Product9/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 66,
                    ProductLineID = 20,
                    Image = baseURL + "Product9/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 67,
                    ProductLineID = 20,
                    Image = baseURL + "Product9/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 68,
                    ProductLineID = 20,
                    Image = baseURL + "Product9/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 69,
                    ProductLineID = 21,
                    Image = baseURL + "Product10/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 70,
                    ProductLineID = 21,
                    Image = baseURL + "Product10/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 71,
                    ProductLineID = 21,
                    Image = baseURL + "Product10/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 72,
                    ProductLineID = 21,
                    Image = baseURL + "Product10/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 73,
                    ProductLineID = 22,
                    Image = baseURL + "Product10/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 74,
                    ProductLineID = 22,
                    Image = baseURL + "Product10/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 75,
                    ProductLineID = 22,
                    Image = baseURL + "Product10/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 76,
                    ProductLineID = 22,
                    Image = baseURL + "Product10/Line2/4.webp"
                }
            );
        }
        static void AddProductImage2(ModelBuilder modelBuilder)
        {
            string baseURL = "Images/Product/";
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    ID = 77,
                    ProductLineID = 23,
                    Image = baseURL + "Product11/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 78,
                    ProductLineID = 23,
                    Image = baseURL + "Product11/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 79,
                    ProductLineID = 23,
                    Image = baseURL + "Product11/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 80,
                    ProductLineID = 23,
                    Image = baseURL + "Product11/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 81,
                    ProductLineID = 24,
                    Image = baseURL + "Product12/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 82,
                    ProductLineID = 24,
                    Image = baseURL + "Product12/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 83,
                    ProductLineID = 24,
                    Image = baseURL + "Product12/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 84,
                    ProductLineID = 24,
                    Image = baseURL + "Product12/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 85,
                    ProductLineID = 25,
                    Image = baseURL + "Product12/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 86,
                    ProductLineID = 25,
                    Image = baseURL + "Product12/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 87,
                    ProductLineID = 25,
                    Image = baseURL + "Product12/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 88,
                    ProductLineID = 25,
                    Image = baseURL + "Product12/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 89,
                    ProductLineID = 26,
                    Image = baseURL + "Product12/Line3/1.webp"
                },
                new ProductImage()
                {
                    ID = 90,
                    ProductLineID = 26,
                    Image = baseURL + "Product12/Line3/2.webp"
                },
                new ProductImage()
                {
                    ID = 91,
                    ProductLineID = 26,
                    Image = baseURL + "Product12/Line3/3.webp"
                },
                new ProductImage()
                {
                    ID = 92,
                    ProductLineID = 26,
                    Image = baseURL + "Product12/Line3/4.webp"
                },
                new ProductImage()
                {
                    ID = 93,
                    ProductLineID = 27,
                    Image = baseURL + "Product12/Line4/1.webp"
                },
                new ProductImage()
                {
                    ID = 94,
                    ProductLineID = 27,
                    Image = baseURL + "Product12/Line4/2.webp"
                },
                new ProductImage()
                {
                    ID = 95,
                    ProductLineID = 27,
                    Image = baseURL + "Product12/Line4/3.webp"
                },
                new ProductImage()
                {
                    ID = 96,
                    ProductLineID = 27,
                    Image = baseURL + "Product12/Line4/4.webp"
                },
                new ProductImage()
                {
                    ID = 97,
                    ProductLineID = 27,
                    Image = baseURL + "Product12/Line4/5.webp"
                },
                new ProductImage()
                {
                    ID = 98,
                    ProductLineID = 28,
                    Image = baseURL + "Product12/Line5/1.webp"
                },
                new ProductImage()
                {
                    ID = 99,
                    ProductLineID = 28,
                    Image = baseURL + "Product12/Line5/2.webp"
                },
                new ProductImage()
                {
                    ID = 100,
                    ProductLineID = 28,
                    Image = baseURL + "Product12/Line5/3.webp"
                },
                new ProductImage()
                {
                    ID = 101,
                    ProductLineID = 28,
                    Image = baseURL + "Product12/Line5/4.webp"
                },
                new ProductImage()
                {
                    ID = 102,
                    ProductLineID = 29,
                    Image = baseURL + "Product13/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 103,
                    ProductLineID = 29,
                    Image = baseURL + "Product13/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 104,
                    ProductLineID = 29,
                    Image = baseURL + "Product13/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 105,
                    ProductLineID = 29,
                    Image = baseURL + "Product13/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 106,
                    ProductLineID = 29,
                    Image = baseURL + "Product13/Line1/5.webp"
                },
                new ProductImage()
                {
                    ID = 107,
                    ProductLineID = 30,
                    Image = baseURL + "Product13/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 108,
                    ProductLineID = 30,
                    Image = baseURL + "Product13/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 109,
                    ProductLineID = 30,
                    Image = baseURL + "Product13/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 110,
                    ProductLineID = 30,
                    Image = baseURL + "Product13/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 111,
                    ProductLineID = 30,
                    Image = baseURL + "Product13/Line2/5.webp"
                },
                new ProductImage()
                {
                    ID = 112,
                    ProductLineID = 31,
                    Image = baseURL + "Product13/Line3/1.webp"
                },
                new ProductImage()
                {
                    ID = 113,
                    ProductLineID = 31,
                    Image = baseURL + "Product13/Line3/2.webp"
                },
                new ProductImage()
                {
                    ID = 114,
                    ProductLineID = 31,
                    Image = baseURL + "Product13/Line3/3.webp"
                },
                new ProductImage()
                {
                    ID = 115,
                    ProductLineID = 31,
                    Image = baseURL + "Product13/Line3/4.webp"
                },
                new ProductImage()
                {
                    ID = 116,
                    ProductLineID = 32,
                    Image = baseURL + "Product14/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 117,
                    ProductLineID = 32,
                    Image = baseURL + "Product14/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 118,
                    ProductLineID = 32,
                    Image = baseURL + "Product14/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 119,
                    ProductLineID = 32,
                    Image = baseURL + "Product14/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 120,
                    ProductLineID = 33,
                    Image = baseURL + "Product15/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 121,
                    ProductLineID = 33,
                    Image = baseURL + "Product15/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 122,
                    ProductLineID = 33,
                    Image = baseURL + "Product15/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 123,
                    ProductLineID = 33,
                    Image = baseURL + "Product15/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 124,
                    ProductLineID = 34,
                    Image = baseURL + "Product16/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 125,
                    ProductLineID = 34,
                    Image = baseURL + "Product16/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 126,
                    ProductLineID = 34,
                    Image = baseURL + "Product16/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 127,
                    ProductLineID = 34,
                    Image = baseURL + "Product16/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 128,
                    ProductLineID = 35,
                    Image = baseURL + "Product16/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 129,
                    ProductLineID = 35,
                    Image = baseURL + "Product16/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 130,
                    ProductLineID = 35,
                    Image = baseURL + "Product16/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 131,
                    ProductLineID = 36,
                    Image = baseURL + "Product17/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 132,
                    ProductLineID = 36,
                    Image = baseURL + "Product17/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 133,
                    ProductLineID = 36,
                    Image = baseURL + "Product17/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 134,
                    ProductLineID = 36,
                    Image = baseURL + "Product17/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 135,
                    ProductLineID = 37,
                    Image = baseURL + "Product17/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 136,
                    ProductLineID = 37,
                    Image = baseURL + "Product17/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 137,
                    ProductLineID = 37,
                    Image = baseURL + "Product17/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 138,
                    ProductLineID = 37,
                    Image = baseURL + "Product17/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 139,
                    ProductLineID = 38,
                    Image = baseURL + "Product18/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 140,
                    ProductLineID = 38,
                    Image = baseURL + "Product18/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 141,
                    ProductLineID = 38,
                    Image = baseURL + "Product18/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 142,
                    ProductLineID = 38,
                    Image = baseURL + "Product18/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 143,
                    ProductLineID = 38,
                    Image = baseURL + "Product18/Line1/5.webp"
                },
                new ProductImage()
                {
                    ID = 144,
                    ProductLineID = 39,
                    Image = baseURL + "Product18/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 145,
                    ProductLineID = 39,
                    Image = baseURL + "Product18/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 146,
                    ProductLineID = 39,
                    Image = baseURL + "Product18/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 147,
                    ProductLineID = 39,
                    Image = baseURL + "Product18/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 148,
                    ProductLineID = 40,
                    Image = baseURL + "Product19/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 149,
                    ProductLineID = 40,
                    Image = baseURL + "Product19/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 150,
                    ProductLineID = 40,
                    Image = baseURL + "Product19/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 151,
                    ProductLineID = 40,
                    Image = baseURL + "Product19/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 152,
                    ProductLineID = 41,
                    Image = baseURL + "Product19/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 153,
                    ProductLineID = 41,
                    Image = baseURL + "Product19/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 154,
                    ProductLineID = 41,
                    Image = baseURL + "Product19/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 155,
                    ProductLineID = 41,
                    Image = baseURL + "Product19/Line2/4.webp"
                },
                new ProductImage()
                {
                    ID = 156,
                    ProductLineID = 42,
                    Image = baseURL + "Product20/Line1/1.webp"
                },
                new ProductImage()
                {
                    ID = 157,
                    ProductLineID = 42,
                    Image = baseURL + "Product20/Line1/2.webp"
                },
                new ProductImage()
                {
                    ID = 158,
                    ProductLineID = 42,
                    Image = baseURL + "Product20/Line1/3.webp"
                },
                new ProductImage()
                {
                    ID = 159,
                    ProductLineID = 42,
                    Image = baseURL + "Product20/Line1/4.webp"
                },
                new ProductImage()
                {
                    ID = 160,
                    ProductLineID = 42,
                    Image = baseURL + "Product20/Line1/5.webp"
                },
                new ProductImage()
                {
                    ID = 161,
                    ProductLineID = 43,
                    Image = baseURL + "Product20/Line2/1.webp"
                },
                new ProductImage()
                {
                    ID = 162,
                    ProductLineID = 43,
                    Image = baseURL + "Product20/Line2/2.webp"
                },
                new ProductImage()
                {
                    ID = 163,
                    ProductLineID = 43,
                    Image = baseURL + "Product20/Line2/3.webp"
                },
                new ProductImage()
                {
                    ID = 164,
                    ProductLineID = 43,
                    Image = baseURL + "Product20/Line2/4.webp"
                }
                );
        }
        static void AddProductImage3(ModelBuilder modelBuilder)
        {
            string baseURL = "Images/Product/";
            //modelBuilder.Entity<ProductImage>().HasData();
        }
        static void AddProductOccation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Occation>().HasData(
                new Product_Occation()
                {
                    ID = 1,
                    OccationID = 1,
                    ProductID = 1
                },
                new Product_Occation()
                {
                    ID = 2,
                    OccationID = 1,
                    ProductID = 3
                },
                new Product_Occation()
                {
                    ID = 3,
                    OccationID = 1,
                    ProductID = 4
                },
                new Product_Occation()
                {
                    ID = 4,
                    OccationID = 1,
                    ProductID = 5
                },
                new Product_Occation()
                {
                    ID = 5,
                    OccationID = 2,
                    ProductID = 3
                },
                new Product_Occation()
                {
                    ID = 6,
                    OccationID = 2,
                    ProductID = 7
                },
                new Product_Occation()
                {
                    ID = 7,
                    OccationID = 2,
                    ProductID = 8
                },
                new Product_Occation()
                {
                    ID = 8,
                    OccationID = 3,
                    ProductID = 2
                },
                new Product_Occation()
                {
                    ID = 9,
                    OccationID = 3,
                    ProductID = 4
                },
                new Product_Occation()
                {
                    ID = 10,
                    OccationID = 3,
                    ProductID = 10
                },
                new Product_Occation()
                {
                    ID = 11,
                    OccationID = 4,
                    ProductID = 1
                }
                );
        }
        static void AddProductSubcategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_SubCategory>().HasData(
                new Product_SubCategory()
                {
                    ID = 1,
                    ProductID = 1,
                    SubcategoryID = 1
                },
                new Product_SubCategory()
                {
                    ID = 2,
                    ProductID = 1,
                    SubcategoryID = 3
                },
                new Product_SubCategory()
                {
                    ID = 3,
                    ProductID = 2,
                    SubcategoryID = 2
                },
                new Product_SubCategory()
                {
                    ID = 4,
                    ProductID = 2,
                    SubcategoryID = 6
                },
                new Product_SubCategory()
                {
                    ID = 5,
                    ProductID = 2,
                    SubcategoryID = 7
                }
                );
        }
        static void AddProvince(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                new Province()
                {
                    ID = 1,
                    Name= "Ninh Kieu",
                    CityID = 1,
                },
                new Province()
                {
                    ID = 2,
                    Name = "Binh Thuy",
                    CityID = 1,
                },
                new Province()
                {
                    ID = 3,
                    Name = "O Mon",
                    CityID = 1,
                },
                new Province()
                {
                    ID = 4,
                    Name = "Hai Chau",
                    CityID = 2,
                },
                new Province()
                {
                    ID = 5,
                    Name = "Cam Le",
                    CityID = 2,
                },
                new Province()
                {
                    ID = 6,
                    Name = "Thanh Khe",
                    CityID = 2,
                },
                new Province()
                {
                    ID = 7,
                    Name = "Hong Kong Island",
                    CityID = 6,
                },
                new Province()
                {
                    ID = 8,
                    Name = "New Territories East",
                    CityID = 6,
                },
                new Province()
                {
                    ID = 9,
                    Name = "Kowloon West",
                    CityID = 6,
                }
                );
        }
    }
}
