﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    public class Product
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Country}), ціна: {Price}";
        }
    }

}
