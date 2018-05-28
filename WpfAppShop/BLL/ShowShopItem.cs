using DAL.Domain;
using DAL.EF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ShowShopItem
    {
        public ShopContext db;

        public ShowShopItem()
        {

            db = new ShopContext();

        }

        public IEnumerable Show(Shop shop)
        {
            return (from shopItem in db.ShopItems
                   join product in db.Products on shopItem.ProductId equals product.Id
                   join sh in db.Shops on shopItem.ShopId equals sh.Id
                   where shopItem.ShopId == shop.Id
                   select new
                   {
                       product.Name,
                       product.Price,
                       shopItem.Count,
                       TotalPrice = product.Price * shopItem.Count
                   }).ToList();

        }
    }
}
