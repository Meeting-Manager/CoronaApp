using CoronaApp.Services;
using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public class PatientDataAccess: IPatientDataAccess
    {
        private IDB _db;

        public PatientDataAccess(IDB db)
        {
            _db = db;
        }
    
        public async Task<List<Location>> GetLocationByPatiantId(string id)
        {
            List<Location> locations = await _db.GetLocations();
                return locations.FindAll(l => l.PatientId.Id == id);
        }

        public async Task PostLocation(Location location)
        {
           await _db.AddLocations(location);
        }
    }
}
