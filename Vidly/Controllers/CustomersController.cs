using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class Customers:Controller
    {
        // GET: /Customers
        public ViewResult Index()
        {
            var exampleCustomer = new Customer();
            exampleCustomer.Id = 1;
            exampleCustomer.Name = "Example Customer";
            return View (exampleCustomer);
        }
    }    
}