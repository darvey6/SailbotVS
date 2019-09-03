using Microsoft.AspNetCore.Mvc;
using SailbotVSv3.Managers;
using SailbotVSv3.Models;
using SailbotVSv3.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Controllers
{
    public class RayeController : Controller
    {
        private readonly SailbotContext context;

        public RayeController(SailbotContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Summary()
        {
            var windManager = new SensorManager<Wind>(context);
            var winchMotorManager = new SensorManager<WinchMotor>(context);
            var rudderMotorManager = new SensorManager<RudderMotor>(context);
            var gpsManager = new SensorManager<GPS>(context);
            var boomAngleManager = new SensorManager<BoomAngle>(context);
            var bmsManager = new SensorManager<BMS>(context);
            var accelerometerManager = new SensorManager<Accelerometer>(context);

            var windSensorModel = new SensorViewModel
            {
                Sensors = windManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(Wind),
                RenderButtons = false
            };

            var winchMotorSensorModel = new SensorViewModel
            {
                Sensors = winchMotorManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(WinchMotor),
                RenderButtons = false
            };

            var rudderMotorSensorModel = new SensorViewModel
            {
                Sensors = rudderMotorManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(RudderMotor),
                RenderButtons = false
            };

            var gpsSensorModel = new SensorViewModel
            {
                Sensors = gpsManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(GPS),
                RenderButtons = false
            };

            var boomAngleSensorModel = new SensorViewModel
            {
                Sensors = boomAngleManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(BoomAngle),
                RenderButtons = false
            };

            var bmsSensorModel = new SensorViewModel
            {
                Sensors = bmsManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(BMS),
                RenderButtons = false
            };

            var accelerometerSensorModel = new SensorViewModel
            {
                Sensors = accelerometerManager.GetAll().Select(i => i as ISensor).ToList(),
                Type = typeof(Accelerometer),
                RenderButtons = false
            };

            var model = new RayeViewModel
            {
                Sensors = new List<SensorViewModel>
                {
                    windSensorModel,
                    winchMotorSensorModel,
                    rudderMotorSensorModel,
                    gpsSensorModel,
                    boomAngleSensorModel,
                    bmsSensorModel,
                    accelerometerSensorModel
                }
            };
            return View("../Boat/Raye/Summary", model);
        }
    }
}
