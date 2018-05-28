using DAL.Domain;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class AddProduct
    {
        public ProductRepository product;

        public AddProduct()
        {

            product = new ProductRepository();

        }

        public bool AddPr(string name, string description, decimal price)
        {
            try
            {

                product.Create(new Product { Name = name, Description = description, Price = price});

                product.Save();

                return true;

            }

            catch (Exception)
            {
                return false;
            }

        }
    }
}
