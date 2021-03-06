﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ICollection<ShopItem> ShopItems { get; set; }
    }
}
