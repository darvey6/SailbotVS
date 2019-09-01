using Microsoft.AspNetCore.Mvc;
using SailbotVSv3.Models;
using SailbotVSv3.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SailbotVSv3.Component
{
    public class SensorViewComponent : ViewComponent
    {
        private readonly SailbotContext context;

        public SensorViewComponent(SailbotContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(SensorViewModel model)
        {
            return View("/Views/Boat/Components/Sensor.cshtml", model);
        }
    }
}
