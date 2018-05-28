using DAL.Domain;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class AddShop
    {
        public ShopRepository shop;

        public AddShop()
        {

            shop = new ShopRepository();

        }

        public bool AddShp(string name, string address)
        { 
            try
            {

                shop.Create(new Shop { Name = name, Addres = address});

                shop.Save();

                return true;

            }

            catch (Exception)
            {
                return false;
            }

        }
    }
}
