using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaApp.Services;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ILocationBusinessLogic _locationBusinessLogic;

        public LocationsController(ILocationBusinessLogic locationBusinessLogic)
        {
            
            //throw new Exception();

            _locationBusinessLogic = locationBusinessLogic;
                 
        }
        // GET: api/<LocationController>
        [HttpGet]
        public async Task<List<Location>> GetLocation()
        {
            
           return await _locationBusinessLogic.GetLocation();
        }

        // GET api/<LocationController>/getByCity
        [HttpGet("getByCity")]
        public async Task<List<Location>> getLocationByCity([FromQuery]string city)
        {
           
            return await _locationBusinessLogic.GetLocationByCity(city);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
