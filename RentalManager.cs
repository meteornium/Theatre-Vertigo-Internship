using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheatreCMS3.Models;

namespace TheatreCMS3.Areas.Rent.Models
{
    public class RentalManager : ApplicationUser
    {
        public int RetiredRentals { get; set; }
        public int RefurbishedRentals { get; set; }
}
