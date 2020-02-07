using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LovgrenMIS4200.Models
{
    public class Owner
    {
        public int ownerID { get; set; }
        public string ownerLastName { get; set; }
        public string ownerFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fullName { get { return ownerLastName + ", " + ownerFirstName; } }

    }
}