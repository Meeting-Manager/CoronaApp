
using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public class LocationBusinessLogic: ILocationBusinessLogic
    {
        private ILocationDataAccess _locationDataAccess;
        public LocationBusinessLogic(ILocationDataAccess locationDataAccess)
        {
            _locationDataAccess = locationDataAccess;
        }
        public async Task<List<Location>> GetLocation()
        {
            return await _locationDataAccess.GetLocation();
        }
        public async Task<List<Location>> GetLocationByCity(string city)
        {
            return await _locationDataAccess.GetLocationByCity(city);      
        }
        
    }
}
