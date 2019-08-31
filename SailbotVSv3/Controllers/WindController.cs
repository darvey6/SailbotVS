using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;
using SailbotVSv3.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SailbotVSv3.Controllers
{
    public class WindController : Controller
    {
        private SailbotContext context;

        public WindController(SailbotContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var windManager = new WindRepository(context);
            var listOfWind = windManager.GetAllWind();

            var windViewModel = new WindViewModel
            {
                winds = listOfWind
            };

            return View(windViewModel);
        }

    }
}
