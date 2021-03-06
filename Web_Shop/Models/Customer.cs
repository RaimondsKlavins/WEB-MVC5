using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Shop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string FamilyName { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string PostAddress { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public decimal Credit { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string PaymentInstrumentIDs { get; set; } // "cardID_1 | cardID_2  | chequeID_1" 

    }
}