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
            AddSize(modelBuilder);
            AddTexture(modelBuilder);

            AddCity(modelBuilder);
            AddFavoriteDesigner(modelBuilder);
            AddProduct(modelBuilder);
            AddSubcategory(modelBuilder);
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
                    Name = "Adrienne Landau"
                },
                new Desinger()
                {
                    ID = 2,
                    Name = "African Botanics"
                },
                new Desinger()
                {
                    ID = 3,
                    Name = "Anastasia Beverly Hills"
                },
                new Desinger()
                {
                    ID = 4,
                    Name = "BCBGeneration"
                },
                new Desinger()
                {
                    ID = 5,
                    Name = "Burberry"
                },
                new Desinger()
                {
                    ID = 6,
                    Name = "blendSMART"
                },
                new Desinger()
                {
                    ID = 7,
                    Name = "Coco & Eve"
                },
                new Desinger()
                {
                    ID = 8,
                    Name = "Corkcicle"
                },
                new Desinger()
                {
                    ID = 9,
                    Name = "Castaner"
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
        static void AddSize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasData(
                new Size()
                {
                    ID = 1,
                    Key = "XXS"
                },
                new Size()
                {
                    ID = 2,
                    Key = "XS"
                },
                new Size()
                {
                    ID = 3,
                    Key = "S"
                },
                new Size()
                {
                    ID = 4,
                    Key = "M"
                },
                new Size()
                {
                    ID = 5,
                    Key = "L"
                },
                new Size()
                {
                    ID = 6,
                    Key = "XL"
                },
                new Size()
                {
                    ID = 7,
                    Key = "XXL"
                }
                );
        }
        static void AddTexture(ModelBuilder modelBuilder)
        {
            string baseURL = "Images/Texture/";
            modelBuilder.Entity<Texture>().HasData(
                // Product 1 - 1
                new Texture()
                {
                    ID = 1,
                    Name = "Blue",
                    Image = baseURL + "blue.webp"
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
                    Name = "Lilac",
                    Image = baseURL + "lilac.webp"
                },
                // Product 1 - 2
                new Texture()
                {
                    ID = 4,
                    Name = "Blush",
                    Image = baseURL + "blush.webp"
                },
                new Texture()
                {
                    ID = 5,
                    Name = "Hot Pink",
                    Image = baseURL + "hot-pink.webp"
                },
                // Product 1 - 3
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
                // Product 1 - 4
                new Texture()
                {
                    ID = 8,
                    Name = "Taupe",
                    Image = baseURL + "taupe.webp"
                },
                new Texture()
                {
                    ID = 9,
                    Name = "Baby Blue",
                    Image = baseURL + "baby-blue.webp"
                },
                // Product 1 - 5
                new Texture()
                {
                    ID = 10,
                    Name = "Abstract Neon Dot",
                    Image = baseURL + "abstract-neon-dot.webp"
                },
                new Texture()
                {
                    ID = 11,
                    Name = "Multi Watercolor",
                    Image = baseURL + "multi-watercolor.webp"
                },
                // Product 2 - 1
                new Texture()
                {
                    ID = 12,
                    Name = "Black",
                    Image = baseURL + "black2.webp"
                },
                // Product 2 - 2
                new Texture()
                {
                    ID = 13,
                    Name = "Acid Wash Black",
                    Image = baseURL + "acid-wash-black.webp"
                },
                new Texture()
                {
                    ID = 14,
                    Name = "Tan",
                    Image = baseURL + "tan.webp"
                },
                new Texture()
                {
                    ID = 15,
                    Name = "Red",
                    Image = baseURL + "red.webp"
                },
                new Texture()
                {
                    ID = 16,
                    Name = "White",
                    Image = baseURL + "white.webp"
                },
                // Product 2 - 3
                new Texture()
                {
                    ID = 17,
                    Name = "Faded Jean",
                    Image = baseURL + "faded-jean.webp"
                },
                // Product 3 - 1
                new Texture()
                {
                    ID = 18,
                    Name = "Namibia",
                    Image = baseURL + "namibia.webp"
                },
                // Product 3 - 2
                new Texture()
                {
                    ID = 19,
                    Name = "Citron",
                    Image = baseURL + "citron.webp"
                },
                new Texture()
                {
                    ID = 20,
                    Name = "Fire",
                    Image = baseURL + "fire.webp"
                },
                new Texture()
                {
                    ID = 21,
                    Name = "Bone",
                    Image = baseURL + "bone.webp"
                },
                // Product 3 - 3
                new Texture()
                {
                    ID = 22,
                    Name = "Paprika",
                    Image = baseURL + "paprika.webp"
                },
                new Texture()
                {
                    ID = 23,
                    Name = "Turmeric",
                    Image = baseURL + "turmeric.webp"
                }
                );
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
                    Name = "Cassini Dress",
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
                    Name = "Morgan Biker Jacket",
                    Price = 659,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 6,
                    DesignerID = 6,
                    Status = Enums.ProductStatus.Stocking,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 7,
                    Name = "x REVOLVE Dylan Jacket",
                    Price = 295,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 6,
                    DesignerID = 7,
                    Status = Enums.ProductStatus.Stocking,
                    SleeveLengthState = Enums.SleeveLengthState.ShortSleeve
                },
                new Product()
                {
                    ID = 8,
                    Name = "Donna Jacket",
                    Price = 595,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 6,
                    DesignerID = 8,
                    Status = Enums.ProductStatus.Stocking,
                    SleeveLengthState = Enums.SleeveLengthState.LongSleeve
                },
                new Product()
                {
                    ID = 9,
                    Name = "Slit Leather Pant",
                    Price = 995,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 6,
                    DesignerID = 9,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi
                },
                new Product()
                {
                    ID = 10,
                    Name = "Carmella Leather Corset",
                    Price = 298,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 6,
                    DesignerID = 1,
                    Status = Enums.ProductStatus.Stocking,
                    SleeveLengthState = Enums.SleeveLengthState.Strapless
                },
                new Product()
                {
                    ID = 11,
                    Name = "Gigi Maxi Skirt",
                    Price = 101,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 12,
                    DesignerID = 2,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.Midi
                },
                new Product()
                {
                    ID = 12,
                    Name = "x REVOLVE Mini Ludlow Slit Skirt",
                    Price = 207,
                    Description = "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105",
                    CategoryID = 12,
                    DesignerID = 3,
                    Status = Enums.ProductStatus.Stocking,
                    LengthState = Enums.LengthState.HiLow
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
    }
}
