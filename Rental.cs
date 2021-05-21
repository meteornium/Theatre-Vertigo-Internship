using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Rent.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }
        public string RentalName { get; set; }
        public int RentalCost { get; set; }
        public string FlawsAndDamages { get; set; }
    }
}
