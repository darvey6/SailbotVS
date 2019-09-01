using Microsoft.AspNetCore.Mvc;
using SailbotVSv3.Managers;
using SailbotVSv3.Models;
using SailbotVSv3.ViewModels;

namespace SailbotVSv3.Controllers
{
    public class RayeController : Controller
    {
        private SailbotContext context;

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
            var model = new RayeViewModel
            {
                Winds = windManager.GetAllWind(),
                WinchMotors = winchMotorManager.GetAllWinchMotor(),
                RudderMotors = rudderMotorManager.GetAllRudderMotor(),
                Gps = gpsManager.GetAllGPS(),
                BoomAngles = boomAngleManager.GetAllBoomAngle(),
                Bms = bmsManager.GetAllBMS(),
                Accelerometers = accelerometerManager.GetAllAccelerometer()
            };
            return View("../Boat/Raye/Summary", model);
        }
    }
}
