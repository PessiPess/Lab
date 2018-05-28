using DAL.Domain;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ShopContext db;



        public ProductRepository()

        {

            this.db = new ShopContext();

        }



        public virtual IEnumerable<Product> GetList()

        {

            return db.Products;

        }



        public Product Get(int id)

        {

            return db.Products.Find(id);

        }



        public virtual void Create(Product product)

        {

            db.Products.Add(product);

        }



        public void Update(Product emp)

        {

            db.Entry(emp).State = EntityState.Modified;

        }



        public void Delete(int id)

        {

            Product product = db.Products.Find(id);

            if (product != null)

                db.Products.Remove(product);

        }



        public virtual void Save()

        {

            db.SaveChanges();

        }
    }
}
