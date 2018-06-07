using DAL.Domain;
using DAL.EF;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AddShopItem
    {
        public ShopItemRepository db;

        public AddShopItem()
        {

            db = new ShopItemRepository();

        }

        public bool AddShpItem(int productId, int shopId, int c)
        {
            try
            {
                ShopItem item = db.GetList().Where(s=>s.ProductId == productId && s.ShopId==shopId).FirstOrDefault();

                if (item == null && c>0)
                {
                    db.Create(new ShopItem {ProductId = productId, ShopId = shopId , Count = c});

                }
                else
                    if (item!=null && c + item.Count > 0)
                    {
                        item.Count += c;
                        db.Update(item);

                    }
                    else
                    {
                        db.Delete(item.Id);
                    }


                db.Save();
                return true;

            }

            catch (Exception)
            {
                return false;
            }

        }
    }
}
