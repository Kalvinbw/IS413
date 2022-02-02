using System;
using System.ComponentModel.DataAnnotations;

namespace mission4.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "A Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A Year is required")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "A Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "A Rating is required")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25, MinimumLength = 0)]
        public string Notes { get; set; }

        [Required(ErrorMessage = "A Category is required")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
