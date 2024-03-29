﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspSneakers.Domain
{
    public class OrderLine : Entity
    {
        public int OrderId { get; set; }
        public int ProductSizeId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }

        public virtual Order Order { get; set; }
        public virtual ProductSize ProductSize { get; set; }
    }
}
