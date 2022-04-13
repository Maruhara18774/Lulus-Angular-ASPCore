using Lulus.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lulus.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Lulus.Data.EF
{
    public class LulusDBContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public LulusDBContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new DesignerConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteDesignerConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteProductConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteSubcategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new OccationConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new Product_OccationConfiguration());
            modelBuilder.ApplyConfiguration(new Product_SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLine_SizeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLineConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new SaleConfiguration());
            modelBuilder.ApplyConfiguration(new SizeConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TextureConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Seed();
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Desinger> Desingers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Occation> Occations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Occation> Product_Occations { get; set; }
        public DbSet<Product_SubCategory> Product_SubCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<ProductLine_Size> ProductLine_Sizes { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Texture> Textures { get; set; }
    }
}
