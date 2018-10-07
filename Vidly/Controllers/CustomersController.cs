using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Identity;
using Vidly.Models;

namespace Vidly.Controllers
{
    [RoutePrefix("movies")]
    public class CustomersController : Controller
    {
        private AuthContext context = new AuthContext();
        // GET: Customers
        public ActionResult Index()
        {
            var customers = context.Customers.Include(x => x.MembershipType).ToList();
            return View(customers);
        }

        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = context.Customers.FirstOrDefault(x => x.ID == id);
            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}