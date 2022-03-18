﻿using Lulus.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class Order: BaseAttribute
    {
        public double Total { get; set; }
        public Guid UserID { get; set; }
        public OrderStatus Status { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }


    }
}
