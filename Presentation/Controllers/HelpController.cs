using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class HelpController : Controller
    {
        [HttpGet]
        //This method will be called using a get request
        //purpose is to load the page (contact.cshtml)
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]//HttpPost: Will allow method to have the same name
                  //This method includes a method overflow
        public IActionResult Contact(string email, string query)
        {
            return View();
        }
    }
}