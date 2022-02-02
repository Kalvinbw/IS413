using System;
using System.ComponentModel.DataAnnotations;

namespace mission4.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "A category is required")]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
