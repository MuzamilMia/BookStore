using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required! ")]
        public string Title { get; set; }=string.Empty;
        [Required(ErrorMessage = "Author is required! ")]
        public string Author { get; set; } = string.Empty;
        [Required(ErrorMessage = "Price is required! ")]
        public decimal price { get; set; }
        [Required(ErrorMessage = "Quantity is required! ")]
        public int quantity { get; set; }
        
    }
}
