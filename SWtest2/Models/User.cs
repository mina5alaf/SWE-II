using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SWtest2.Models
{
    public class User
    {
        [StringLength(50,MinimumLength =8,ErrorMessage ="Password shouldn't be less than 8 chars")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="YOU NEED TO ENTER YOUR PASSWORD !!")]
        public string password { get; set; }

        [Required(ErrorMessage = "YOU NEED TO ENTER YOUR FULLNAME !!")]
        public string Fullname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "YOU NEED TO ENTER YOUR EMAIL !!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "YOU NEED TO ENTER YOUR USER NAME !!")]
        public string Username { get; set; }
    }
}