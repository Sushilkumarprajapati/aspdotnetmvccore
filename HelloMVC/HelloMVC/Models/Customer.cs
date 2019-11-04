using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HelloMVC.Models
{
    public class Customer
    {
        public string Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage ="Your Name is too long!")]
        [DisplayName("Enter Your FullName")]
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}