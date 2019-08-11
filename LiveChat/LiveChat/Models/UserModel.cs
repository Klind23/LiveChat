using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiveChat.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="This field is required")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "This field is required")]
        public string ConfirmPassword { get; set; }

        public string LoginErrorMessage { get; set; }

    }

}