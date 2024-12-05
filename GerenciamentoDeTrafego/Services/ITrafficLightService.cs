using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTrafficControl.Models;

namespace SmartTrafficControl.Services
{
    public interface ITrafficLightService
    {
        IEnumerable<TrafficLight> GetAllTrafficLights();
        TrafficLight AddTrafficLight(TrafficLight trafficLight);
        TrafficLight? UpdateTrafficLight(int id, TrafficLight trafficLight);
        bool DeleteTrafficLight(int id);
    }
}
