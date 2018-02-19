using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProjectsHosting.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        [Required(ErrorMessage = "Please provide product name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Please provide unit price")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Please provide product quantity")]
        [Display(Name = "Quantity")]
        public long Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }


    }
}