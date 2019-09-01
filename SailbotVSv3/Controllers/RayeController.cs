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
            var windManager = new WindManager(context);
            var winchMotorManager = new WinchMotorManager(context);
            var rudderMotorManager = new RudderMotorManager(context);
            var gpsManager = new GPSManager(context);
            var boomAngleManager = new BoomAngleManager(context);
            var bmsManager = new BMSManager(context);
            var accelerometerManager = new AccelerometerManager(context);

            var windSensorModel = new SensorViewModel
            {
                Sensors = windManager.GetAllWind().Select(i => i as ISensor).ToList(),
                Type = typeof(Wind),
                RenderButtons = false
            };

            var winchMotorSensorModel = new SensorViewModel
            {
                Sensors = winchMotorManager.GetAllWinchMotor().Select(i => i as ISensor).ToList(),
                Type = typeof(WinchMotor),
                RenderButtons = false
            };

            var rudderMotorSensorModel = new SensorViewModel
            {
                Sensors = rudderMotorManager.GetAllRudderMotor().Select(i => i as ISensor).ToList(),
                Type = typeof(RudderMotor),
                RenderButtons = false
            };

            var gpsSensorModel = new SensorViewModel
            {
                Sensors = gpsManager.GetAllGPS().Select(i => i as ISensor).ToList(),
                Type = typeof(GPS),
                RenderButtons = false
            };

            var boomAngleSensorModel = new SensorViewModel
            {
                Sensors = boomAngleManager.GetAllBoomAngle().Select(i => i as ISensor).ToList(),
                Type = typeof(BoomAngle),
                RenderButtons = false
            };

            var bmsSensorModel = new SensorViewModel
            {
                Sensors = bmsManager.GetAllBMS().Select(i => i as ISensor).ToList(),
                Type = typeof(BMS),
                RenderButtons = false
            };

            var accelerometerSensorModel = new SensorViewModel
            {
                Sensors = accelerometerManager.GetAllAccelerometer().Select(i => i as ISensor).ToList(),
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
