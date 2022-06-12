

using CoronaApp.Services.Models;

namespace CoronaApp.Services
{
    public interface ILocationDataAccess
    {
        public Task<List<Location>> GetLocation();


        public Task<List<Location>> GetLocationByCity(string city);

   
    }
}