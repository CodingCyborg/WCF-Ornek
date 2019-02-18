using Arkadas.Models;
using Arkadas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Arkadas.Controllers
{
    public class HomeController : Controller
    {

        public ApplicationDbContext _context;

        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = context;            
        //}

        public ActionResult Index()
        {

            #region roles
            string UserRole = "Non";
            if (User.IsInRole("Admin"))
            {
                UserRole = "Admin";
            }
            else if (User.IsInRole("Bayi"))
            {
                UserRole = "Bayi";
            }
            else if (User.IsInRole("Musteri"))
            {
                UserRole = "Musteri";
            }
            #endregion

            if (UserRole == "Non")
            {
                return RedirectToAction("Login", "Account");
            }

            var Products = ApplicationDbContext.Create().ProductDetails.Include("Product").Where(i => i.Id > 0).ToList();
            
            var HomeIndexViewModel = new HomeIndexViewModel()
            {
                _context = _context,
                UserRoleName = UserRole,
                ProductList = Products
            };
            return View(HomeIndexViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
