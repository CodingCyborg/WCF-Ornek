using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Arkadas.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdminFiyat { get; set; }
        public string BayiFiyat { get; set; }
        public string MusteriFiyat { get; set; }
    }
}