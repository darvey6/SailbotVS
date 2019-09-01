using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SailbotVSv3.Managers;
using SailbotVSv3.Models;
using SailbotVSv3.ViewModels;

namespace SailbotVSv3.Controllers
{
    public class SensorDetailController : Controller
    {
        private readonly SailbotContext context;

        public SensorDetailController(SailbotContext context)
        {
            this.context = context;
        }

        public IActionResult Sensor(string type)
        {
            List<ISensor> sensors;
            Type t = null;
            switch (type)
            {
                case "Wind":
                    var windManager = new WindManager(context);
                    sensors = windManager.GetAllWind().Select(i => i as ISensor).ToList();
                    t = typeof(Wind);
                    break;
                case "WinchMotor":
                    var winchMotorManager = new WinchMotorManager(context);
                    sensors = winchMotorManager.GetAllWinchMotor().Select(i => i as ISensor).ToList();
                    t = typeof(WinchMotor);
                    break;
                case "RudderMotor":
                    var rudderMotorManager = new RudderMotorManager(context);
                    sensors = rudderMotorManager.GetAllRudderMotor().Select(i => i as ISensor).ToList();
                    t = typeof(RudderMotor);
                    break;
                case "GPS":
                    var gpsManager = new GPSManager(context);
                    sensors = gpsManager.GetAllGPS().Select(i => i as ISensor).ToList();
                    t = typeof(GPS);
                    break;
                case "BoomAngle":
                    var boomAngleManager = new BoomAngleManager(context);
                    sensors = boomAngleManager.GetAllBoomAngle().Select(i => i as ISensor).ToList();
                    t = typeof(BoomAngle);
                    break;
                case "BMS":
                    var bmsManager = new BMSManager(context);
                    sensors = bmsManager.GetAllBMS().Select(i => i as ISensor).ToList();
                    t = typeof(BMS);
                    break;
                case "Accelerometer":
                    var accelerometerManager = new AccelerometerManager(context);
                    sensors = accelerometerManager.GetAllAccelerometer().Select(i => i as ISensor).ToList();
                    t = typeof(Accelerometer);
                    break;
                default:
                    sensors = new List<ISensor>();
                    break;
            }

            var model = new SensorViewModel
            {
                Sensors = sensors,
                Type = t,
                RenderButtons = true
            };
            return View("../Boat/SensorDetail/SensorDetail", model);
        }

        public IActionResult GetSensorHistory(string type, int sensorID)
        {
            // Stub
            // Gets history from the History Table based on the type and sensorID
            return PartialView("../Boat/SensorDetail/SensorHistory");
        }

        [HttpPost]
        public IActionResult UpdateSensor(FormCollection formCollection)
        {
            // Stub
            // Update an entry in the database base on the form collection sent back from the view
            return PartialView();
        }
    }
}