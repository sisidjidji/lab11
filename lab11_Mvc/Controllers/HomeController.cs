using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11_Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            personOfTheYear viewModel = new personOfTheYear();
            {

            }

            return View(viewModel);
        }

        public IActionResult Result()
        {
            return View();
        }

    }
}
