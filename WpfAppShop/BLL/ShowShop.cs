using DAL.Domain;
using DAL.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ShowShop
    {
        public ShopRepository shop;

        public ShowShop()
        {

            shop = new ShopRepository();

        }

        public IEnumerable<Shop> Show()
        {
            return shop.GetList();

        }
    }
}
