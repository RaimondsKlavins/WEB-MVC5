using System.ComponentModel.DataAnnotations;

namespace Web_Shop.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string BookName { get; set; }

        public string Description { get; set; }

        public string Group { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public string ImgPath { get; set; }
    }
}