using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheatreCMS3.Areas.Rent.Models;

namespace TheatreCMS3.Areas.Rent.ViewModels
{
    public class AllRentalsVM
    {      
        public int RentalId { get; set; }
        public string RentalName { get; set; }
        public int RentalCost { get; set; }
        public string FlawsAndDamages { get; set; }
        public int RoomNumber { get; set; }
        public int SquareFootage { get; set; }
        public int MaxOccupancy { get; set; }
        public bool ChokingHazard { get; set; }
        public bool SuffocationHazard { get; set; }
        public int PurchasePrice { get; set; }

        // constructors to modify the data shown based on what the object is (Rental, RentalEquipment, RentalRoom)
        public AllRentalsVM(Rental rental)
        {
            this.RentalId = rental.RentalId;
            this.RentalName = rental.RentalName;
            this.RentalCost = rental.RentalCost;
            this.FlawsAndDamages = rental.FlawsAndDamages;
            if (rental.GetType() == typeof(RentalEquipment))
            {
                AssignRentalEquipment(rental as RentalEquipment);
            } else if (rental.GetType() == typeof(RentalRoom))
            {
                AssignRentalRoom(rental as RentalRoom);
            }
        }

        private void AssignRentalEquipment (RentalEquipment rental)
        {
            this.ChokingHazard = rental.ChokingHazard;
            this.SuffocationHazard = rental.SuffocationHazard;
            this.PurchasePrice = rental.PurchasePrice;
        }

        private void AssignRentalRoom (RentalRoom rental)
        {
            this.RoomNumber = rental.RoomNumber;
            this.SquareFootage = rental.SquareFootage;
            this.MaxOccupancy = rental.MaxOccupancy;
        }
    }
}
