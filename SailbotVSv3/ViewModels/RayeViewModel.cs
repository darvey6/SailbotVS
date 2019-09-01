using SailbotVSv3.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SailbotVSv3.ViewModels
{
    public class RayeViewModel
    {
        public List<Wind> Winds { get; set; }
        public List<WinchMotor> WinchMotors { get; set; }
        public List<RudderMotor> RudderMotors { get; set; }
        public List<GPS> Gps { get; set; }
        public List<BoomAngle> BoomAngles { get; set; }
        public List<BMS> Bms { get; set; }
        public List<Accelerometer> Accelerometers { get; set; }
    }
}
