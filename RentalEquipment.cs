using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Rent.Models
{
    public class RentalEquipment : Rental
    {
        public bool ChokingHazard { get; set; }
        public bool SuffocationHazard { get; set; }
        public int PurchasePrice { get; set; }
    }
}
