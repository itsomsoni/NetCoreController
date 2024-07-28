using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NetCoreController.Models
{
    public class Books
    {
        //[Required]
        //[MinLength(2), MaxLength(4)]
        public int BookId { get; set; }
        [Required]
        [StringLength(100)]
        public string BookName { get; set; }
        public string? Author { get; set; }
    }
}
