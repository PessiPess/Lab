using DAL.Domain;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.Repositories
{
    public class ShopRepository : IRepository<Shop>
    {
        private ShopContext db;



        public ShopRepository()

        {

            this.db = new ShopContext();

        }



        public virtual IEnumerable<Shop> GetList()

        {

            return db.Shops;

        }



        public Shop Get(int id)

        {

            return db.Shops.Find(id);

        }



        public virtual void Create(Shop shop)

        {

            db.Shops.Add(shop);

        }



        public void Update(Shop shop)

        {

            db.Entry(shop).State = EntityState.Modified;

        }



        public void Delete(int id)

        {

            Shop shop = db.Shops.Find(id);

            if (shop != null)

                db.Shops.Remove(shop);

        }



        public virtual void Save()

        {

            db.SaveChanges();

        }
    }
}
