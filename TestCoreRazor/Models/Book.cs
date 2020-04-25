using System.ComponentModel.DataAnnotations;

namespace TestCoreRazor.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string AuthorName { get; set; }
    }
}
