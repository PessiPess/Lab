using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.EF
{
    public class ShopContext : DbContext
    {
       
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }

        static ShopContext()
        {
            Database.SetInitializer<ShopContext>(new StoreDbInitializer());
        }

        public ShopContext()
            : base("DBConnection")
        {
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext db)
        {
            db.Products.Add(new Product { Name = "Гантеля(5кг)", Description = "", Price = 120 });
            db.Products.Add(new Product { Name = "Блин(10кг)", Description = "", Price = 200 });
            db.Products.Add(new Product { Name = "Блин(20кг)", Description = "", Price = 350 });
            db.Products.Add(new Product { Name = "Тренажёр преса", Description = "", Price = 10000 });

            db.Shops.Add(new Shop { Name = "Shop1", Addres = "г.Киев"});
            db.Shops.Add(new Shop { Name = "Shop2", Addres = "г.Харьков"});
            db.Shops.Add(new Shop { Name = "Shop3", Addres = "г. Одесса"});
           
            db.SaveChanges();
        }
    }
}
