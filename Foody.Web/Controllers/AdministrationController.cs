using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Web.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index(string option)
        {
            ViewData["Partial"] = option;

            return View();
        }
    }
}