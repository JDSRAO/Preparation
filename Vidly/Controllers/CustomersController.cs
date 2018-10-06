using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [RoutePrefix("movies")]
    public class CustomersController : Controller
    {
        static List<Customer>  customers = new List<Customer>()
        {
            new Customer() { ID = 1, Name = "KJDS" },
            new Customer() { ID = 2, Name = "RDJ" },
            new Customer() { ID = 3, Name = "Captain America" },
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault(x => x.ID == id);
            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}