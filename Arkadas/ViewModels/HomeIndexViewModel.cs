using Arkadas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Arkadas.ViewModels
{
    public class HomeIndexViewModel
    {
        public ApplicationDbContext _context { get; set; }       
        public string UserRoleName { get; set; }
        public List<ProductDetail> ProductList { get; set; }
    }
}