using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidil.Models;

namespace vidil.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            
            var customer = GetCustomers();

            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
        var customers = new List<Customer> {
            new Customer{Name = "John Smith"},
            new Customer{Name = "Mary Williams"}
            };
        return customers;
        }


        public ViewResult Details(int id)
        {
            return View(id);
        }

    }
}
