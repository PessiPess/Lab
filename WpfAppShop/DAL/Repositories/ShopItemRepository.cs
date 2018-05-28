using DAL.Domain;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.Repositories
{
    public class ShopItemRepository : IRepository<ShopItem>
    {
        private ShopContext db;



        public ShopItemRepository()
        {

            this.db = new ShopContext();

        }



        public virtual IEnumerable<ShopItem> GetList()
        {

            return db.ShopItems;

        }



        public ShopItem Get(int id)
        {

            return db.ShopItems.Find(id);

        }



        public virtual void Create(ShopItem shop)
        {

            db.ShopItems.Add(shop);

        }



        public void Update(ShopItem shop)
        {

            db.Entry(shop).State = EntityState.Modified;

        }



        public void Delete(int id)
        {

            ShopItem shop = db.ShopItems.Find(id);

            if (shop != null)

                db.ShopItems.Remove(shop);

        }



        public virtual void Save()
        {

            db.SaveChanges();

        }
    }
}
