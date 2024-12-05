using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTrafficControl.Models;
using SmartTrafficControl.Services;

namespace SmartTrafficControlo.Services
{
    public class TrafficLightService : ITrafficLightService
    {
        private readonly List<TrafficLight> _trafficLights = new();

        public IEnumerable<TrafficLight> GetAllTrafficLights()
        {
            return _trafficLights;
        }

        public TrafficLight AddTrafficLight(TrafficLight trafficLight)
        {
            trafficLight.Id = _trafficLights.Count + 1;
            _trafficLights.Add(trafficLight);
            return trafficLight;
        }

        public TrafficLight? UpdateTrafficLight(int id, TrafficLight trafficLight)
        {
            var existing = _trafficLights.FirstOrDefault(t => t.Id == id);
            if (existing == null) return null;

            existing.Status = trafficLight.Status;
            existing.TrafficDensity = trafficLight.TrafficDensity;
            existing.WeatherCondition = trafficLight.WeatherCondition;

            return existing;
        }

        public bool DeleteTrafficLight(int id)
        {
            var trafficLight = _trafficLights.FirstOrDefault(t => t.Id == id);
            if (trafficLight == null) return false;

            _trafficLights.Remove(trafficLight);
            return true;
        }
    }
}
