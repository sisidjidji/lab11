using lab11_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab11_Mvc.Models;

namespace lab11_Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PersonOfTheYear> personList = Models.PersonOfTheYear.Getperson();

            PersonOfTheYear viewModel = new PersonOfTheYear();
            {
                PersonOfTheYear = personList;

            }

            return View(viewModel);
        }

        public IActionResult Result()
        {
            return View();
        }

    }
}
