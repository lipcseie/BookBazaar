using System.ComponentModel.DataAnnotations;

namespace BookBazaar.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DispkayOrder { get; set; }

    }
}
