using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTrafficControl.Models
{
  
        public class TrafficLight
        {
            public int Id { get; set; }
            public string Location { get; set; }
            public string Status { get; set; } // Ex: "Green", "Yellow", "Red"
            public int TrafficDensity { get; set; } // Ex: 0 a 100
            public string WeatherCondition { get; set; } // Ex: "Clear", "Rainy"
        }

    }

