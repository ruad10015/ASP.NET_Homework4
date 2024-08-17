using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Homework4.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ("Name is Required"))]

        [MinLength(3, ErrorMessage = "Minimum name should be 3")]
        public string Name { get; set; }

        [Required(ErrorMessage = ("Description Is Required"))]

        [MinLength(5, ErrorMessage = "Minimum description should be 5")]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Value must be at least 1.")]
        public int Discount { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Value must be at least 1.")]
        public int Price { get; set; }
        public Product()
        {

        }
        public Product(int ıd, string name, string description, int discount, int price)
        {
            Id = ıd;
            Name = name;
            Description = description;
            Discount = discount;
            Price = price;
        }

    }
}
