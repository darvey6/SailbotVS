using Microsoft.AspNetCore.Mvc;
using SailbotVSv3.Managers;
using SailbotVSv3.Models;
using SailbotVSv3.ViewModels;
using System.Collections.Generic;

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
            var windManager = new WindManager(context);

            var windViewModel = new WindViewModel
            {
                winds = windManager.GetAllWind(),
                

                
            };

            return View(windViewModel);
        }

    }
}
