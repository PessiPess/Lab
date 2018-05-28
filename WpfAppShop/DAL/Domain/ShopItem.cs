using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain
{
    public class ShopItem
    {
        public int Id { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Count { get; set; }
    }
}
