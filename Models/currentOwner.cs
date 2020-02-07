using LovgrenMIS4200.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LovgrenMIS4200.Models
{
    public class currentOwner
    {
        public int currentOwnerID { get; set; }
        public int qtyofCars { get; set; }
        public int ownerID { get; set; }
        public virtual Owner Owner { get; set; }
        public int carsID { get; set; }
       public virtual Cars Car { get; set; }


    }
}