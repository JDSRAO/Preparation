using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Identity;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [RoutePrefix("customers")]
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

        [Route("new")]
        public ActionResult NewCustomer()
        {
            var viewModel = new NewCustomerViewModel();
            viewModel.MembershipTypes = context.MembershipTypes.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer model)
        {
            if(model != null)
            {
                if(model.ID == 0)
                {
                    context.Customers.Add(model);
                }
                else
                {
                    var customer = context.Customers.FirstOrDefault(x => x.ID == model.ID);
                    customer.Name = model.Name;
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                throw new InvalidOperationException("Error saving customer data");
            }
        }
    }
}