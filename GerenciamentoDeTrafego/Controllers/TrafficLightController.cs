using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SmartTrafficControl.Models;
using SmartTrafficControl.Service;
using SmartTrafficControl.Services;

namespace SmartTrafficControl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrafficLightController : ControllerBase
    {
        private readonly ITrafficLightService _service;

        public TrafficLightController(ITrafficLightService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TrafficLight>> GetAll()
        {
            return Ok(_service.GetAllTrafficLights());
        }

        [HttpPost]
        public ActionResult AddTrafficLight([FromBody] TrafficLight trafficLight)
        {
            var added = _service.AddTrafficLight(trafficLight);
            return Ok(added);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTrafficLight(int id, [FromBody] TrafficLight updatedLight)
        {
            var updated = _service.UpdateTrafficLight(id, updatedLight);
            if (updated == null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTrafficLight(int id)
        {
            var success = _service.DeleteTrafficLight(id);
            if (!success) return NotFound();

            return NoContent();
        }
    }
}
