using System.ComponentModel.DataAnnotations;

namespace Web_Shop.Models
{
    public class Garment
    {
        [Key]
        public int Id { get; set; }

        public string GarmentName { get; set; }

        public string Description { get; set; }

        public string Group { get; set; }

        public string Size { get; set; }

        public string Colour { get; set; }

        public string Producer { get; set; }

        public string Material { get; set; }

        public decimal Price { get; set; }

        public string ImgPath { get; set; }

    }
}