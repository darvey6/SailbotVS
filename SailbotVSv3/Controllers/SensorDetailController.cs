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

        public IActionResult GetUpdateForm(string type, int sensorID)
        {
            var modifiableColumnManager = new ModifiableColumnManager(context);
            ISensor sensor = null;
            Type t = null;
            switch (type)
            {
                case "Wind":
                    sensor = context.Wind.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(Wind);
                    break;
                case "WinchMotor":
                    sensor = context.WinchMotor.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(WinchMotor);
                    break;
                case "RudderMotor":
                    sensor = context.RudderMotor.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(RudderMotor);
                    break;
                case "GPS":
                    sensor = context.GPS.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(GPS);
                    break;
                case "BoomAngle":
                    sensor = context.BoomAngle.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(BoomAngle);
                    break;
                case "BMS":
                    sensor = context.BMS.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(BMS);
                    break;
                case "Accelerometer":
                    sensor = context.Accelerometer.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(Accelerometer);
                    break;
                default:
                    break;
            }
            var model = new SensorFormViewModel
            {
                Sensor = sensor,
                Type = t,
                Columns = modifiableColumnManager.GetModifiableColumns(type)
            };

            return PartialView("../Boat/SensorDetail/SensorUpdate", model);
        }

        [HttpPost]
        public IActionResult UpdateForm(IFormCollection formCollection)
        {
            var sensorID = int.Parse(formCollection["SensorID"].FirstOrDefault());
            var sensorType = formCollection["SensorType"].FirstOrDefault();
            var modifiableColumnManager = new ModifiableColumnManager(context);
            var columns = modifiableColumnManager.GetModifiableColumns(sensorType);
            ISensor sensor = null;
            Type t = null;
            switch (sensorType)
            {
                case "Wind":
                    sensor = context.Wind.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(Wind);
                    break;
                case "WinchMotor":
                    sensor = context.WinchMotor.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(WinchMotor);
                    break;
                case "RudderMotor":
                    sensor = context.RudderMotor.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(RudderMotor);
                    break;
                case "GPS":
                    sensor = context.GPS.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(GPS);
                    break;
                case "BoomAngle":
                    sensor = context.BoomAngle.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(BoomAngle);
                    break;
                case "BMS":
                    sensor = context.BMS.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(BMS);
                    break;
                case "Accelerometer":
                    sensor = context.Accelerometer.Where(w => w.SensorID == sensorID).FirstOrDefault();
                    t = typeof(Accelerometer);
                    break;
                default:
                    break;
            }

            foreach (var column in columns)
            {
                var value = formCollection[column].FirstOrDefault();
                var property = t.GetProperty(column);
                property.SetValue(sensor, Convert.ChangeType(value, property.PropertyType), null);
            }

            context.SaveChanges();

            return RedirectToAction("Sensor", new { type = sensorType });
        }
    }
}