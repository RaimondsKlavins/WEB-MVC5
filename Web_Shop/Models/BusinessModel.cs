using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_Shop.Models
{
    public class BusinessModel
    {
        [Key]
        public int UserId { get; set; }

        public bool IsOk { get; set; }

        public string BuyDescription { get; set; }

        public string Group { get; set; }

        public decimal Price { get; set; }

    }
}