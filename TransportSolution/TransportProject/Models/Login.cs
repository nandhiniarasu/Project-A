using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TransportProject.Models
{
    public class Login
    {
        [Key]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Pass Word")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
