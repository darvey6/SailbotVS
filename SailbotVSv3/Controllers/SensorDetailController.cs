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
            switch(type)
            {
                case "Wind":
                    sensors = new SensorManager<Wind>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                case "WinchMotor":
                    sensors = new SensorManager<WinchMotor>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                case "RudderMotor":
                    sensors = new SensorManager<RudderMotor>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                case "GPS":
                    sensors = new SensorManager<GPS>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                case "BoomAngle":
                    sensors = new SensorManager<BoomAngle>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                case "BMS":
                    sensors = new SensorManager<BMS>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                case "Accelerometer":
                    sensors = new SensorManager<Accelerometer>(context).GetAll().Select(i => i as ISensor).ToList();
                    break;
                default:
                    return null;
            }

            var model = new SensorViewModel
            {
                Sensors = sensors,
                Type = SailbotContext.GetSensorType(type),
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
            switch (type)
            {
                case "Wind":
                    sensor = new SensorManager<Wind>(context).GetSensor(sensorID);
                    break;
                case "WinchMotor":
                    sensor = new SensorManager<WinchMotor>(context).GetSensor(sensorID);
                    break;
                case "RudderMotor":
                    sensor = new SensorManager<RudderMotor>(context).GetSensor(sensorID);
                    break;
                case "GPS":
                    sensor = new SensorManager<GPS>(context).GetSensor(sensorID);
                    break;
                case "BoomAngle":
                    sensor = new SensorManager<BoomAngle>(context).GetSensor(sensorID);
                    break;
                case "BMS":
                    sensor = new SensorManager<BMS>(context).GetSensor(sensorID);
                    break;
                case "Accelerometer":
                    sensor = new SensorManager<Accelerometer>(context).GetSensor(sensorID);
                    break;
                default:
                    break;
            }

            var model = new SensorFormViewModel
            {
                Sensor = sensor,
                Type = SailbotContext.GetSensorType(type),
                Columns = modifiableColumnManager.GetModifiableColumns(type)
            };

            return PartialView("../Boat/SensorDetail/SensorUpdate", model);
        }

        [HttpPost]
        public IActionResult UpdateForm(IFormCollection formCollection)
        {
            var sensorID = int.Parse(formCollection["SensorID"].FirstOrDefault());
            var sensorType = formCollection["SensorType"].FirstOrDefault();
            ISensor sensor = null;
            var type = SailbotContext.GetSensorType(sensorType);
            switch (sensorType)
            {
                case "Wind":
                    sensor = new SensorManager<Wind>(context).GetSensor(sensorID);
                    break;
                case "WinchMotor":
                    sensor = new SensorManager<WinchMotor>(context).GetSensor(sensorID);
                    break;
                case "RudderMotor":
                    sensor = new SensorManager<RudderMotor>(context).GetSensor(sensorID);
                    break;
                case "GPS":
                    sensor = new SensorManager<GPS>(context).GetSensor(sensorID);
                    break;
                case "BoomAngle":
                    sensor = new SensorManager<BoomAngle>(context).GetSensor(sensorID);
                    break;
                case "BMS":
                    sensor = new SensorManager<BMS>(context).GetSensor(sensorID);
                    break;
                case "Accelerometer":
                    sensor = new SensorManager<Accelerometer>(context).GetSensor(sensorID);
                    break;
                default:
                    break;
            }

            var modifiableColumnManager = new ModifiableColumnManager(context);
            var columns = modifiableColumnManager.GetModifiableColumns(sensorType);
            foreach (var column in columns)
            {
                var newValue = formCollection[column].FirstOrDefault();
                var property = type.GetProperty(column);
                property.SetValue(sensor, Convert.ChangeType(newValue, property.PropertyType), null);
            }

            context.SaveChanges();

            return RedirectToAction("Sensor", new { type = sensorType });
        }
    }
}