using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class DeleteProduct
    {
        public ProductRepository product;

        public DeleteProduct()
        {

            product = new ProductRepository();

        }

        public bool Delete(int id)
        {
            try
            {

                product.Delete(id);

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
