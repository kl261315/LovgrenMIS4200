using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LovgrenMIS4200.Models
{
    public class Products
    {
        public int productsID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}