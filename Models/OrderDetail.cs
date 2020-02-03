using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LovgrenMIS4200.Models
{
    public class OrderDetail
    {
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int orderID { get; set; }
        public virtual Orders Order { get; set; }
        public int productID { get; set; }
        public virtual Products Products { get; set; }
}
}