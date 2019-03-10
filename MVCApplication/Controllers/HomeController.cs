using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{
  
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            ViewBag.error = "Please return to the 'Home' page to provide values to use for a result.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {
                if(resultViewModel.quant == 0)
                {
                    Random random = new Random();
                    resultViewModel.quant = random.Next(0, 100);

                }

                if(resultViewModel.leng == 0)
                {
                    Random random = new Random();
                    resultViewModel.leng = random.Next(1, 20);

                }

                RandomValue qbert = new RandomValue("qbert");

                resultViewModel.RandomKeys = qbert.RandomKeys(resultViewModel.quant, resultViewModel.leng);

                return View(resultViewModel);
            }

            return Redirect("/Home/Error");
        }

    }



}
