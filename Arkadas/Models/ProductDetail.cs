using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Arkadas.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }

        public Product Product { get; set; }
        [Required]      
        public int ProductId { get; set; }
        public string DetailExplaination { get; set; }
        public string ImageUrl { get; set; }
    }
}