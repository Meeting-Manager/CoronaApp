using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaApp.Services;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private IPatientBusinessLogic _patientBusinessLogic;
        public PatientsController(IPatientBusinessLogic patientBusinessLogic)
        {
            _patientBusinessLogic = patientBusinessLogic;
        }
               //GET api/<LocationController>/5
        [HttpGet("{id}")]
        public async Task<List<Location>> GetLocationByPatiantId(string id)
        {
            return await _patientBusinessLogic.GetLocationByPatiantId(id);
        }
        // POST api/<LocationController>
        [HttpPost]
        public async Task PostLocation(Location location)
        {
            await _patientBusinessLogic.PostLocation(location);
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
