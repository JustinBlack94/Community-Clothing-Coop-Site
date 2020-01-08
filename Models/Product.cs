using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JB_Final_Project.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Product Description")]
        [StringLength(100, MinimumLength = 2)]
        public string ProductDesc { get; set; }
        [Display(Name = "Product Quality")]
        [StringLength(100, MinimumLength = 2)]
        public string ProductQuality { get; set; }
    }
}