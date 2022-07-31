using System.ComponentModel.DataAnnotations;

namespace Commercial_1.Models
{

    public class ProductModel
    {
        public List<Product> ProductlList { get; set; }
    }
    public class Product
    {
        [Key]
        [Display(Name = "ProductID")]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}
