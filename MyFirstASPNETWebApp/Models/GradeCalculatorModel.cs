using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Models
{
    public class GradeCalculatorModel
    {
        [Required(ErrorMessage = "Assign can't be blank")]
        [Range(0, 100,
            ErrorMessage = "Assign must be between 0 and 100")]
        public int? Assign { get; set; }

        [Required(ErrorMessage = "Group Project can't be blank")]
        [Range(0, 100,
            ErrorMessage = "Group Project must be between 0 and 100")]
        public int? Gp { get; set; }

        [Required(ErrorMessage = "Quiz can't be blank")]
        [Range(0, 100,
            ErrorMessage = "Quiz must be between 0 and 100")]
        public int? Qz { get; set; }

        [Required(ErrorMessage = "Exam can't be blank")]
        [Range(0, 100,
            ErrorMessage = "Exam must be between 0 and 100")]
        public int? Ex { get; set; }

        [Required(ErrorMessage = "Intex can't be blank")]
        [Range(0, 100,
            ErrorMessage = "Intex must be between 0 and 100")]
        public int? Intex { get; set; }
    }
}

// Custom getter and setter
//Setter
//public void setAssign(int input)
//{
//    this.Assign = input;
//}

//Getter
//public int getAssign()
//{
//    return this.Assign;
//}