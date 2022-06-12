


using CoronaApp.Services;
using CoronaApp.Services.Models;

namespace CoronaApp.Dal
{
    public class LocationDataAccess: ILocationDataAccess
    {
       private IDB _db ;
        public LocationDataAccess(IDB db)
        {
            _db = db;
        }

        public async Task<List<Location>> GetLocation()
        {
            return await _db.GetLocations();
        }

        public async Task<List<Location>> GetLocationByCity(string city)
        {
            List<Location>  locations= await _db.GetLocations();
            return locations.FindAll(l => l.City == city);
        }
     

    }
}
