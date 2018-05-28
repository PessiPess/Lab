using DAL.Domain;
using DAL.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ShowProducts
    {
        public ProductRepository product;

        public ShowProducts()
        {

            product = new ProductRepository();

        }

        public IEnumerable<Product> Show()
        {
            return product.GetList();

        }
    }
}
