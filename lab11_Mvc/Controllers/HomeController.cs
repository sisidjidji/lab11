using lab11_Mvc.Models;
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
            PersonOfTheYear viewModel = new PersonOfTheYear();
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
