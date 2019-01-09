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
        public ContentResult Index()
        {
            return Content ("Hola");
        }
    }    
}