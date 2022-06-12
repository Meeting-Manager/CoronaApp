using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public class DB:IDB
    {
        private List<Location> _db=new List<Location>();
        public  async Task<List<Location>> GetLocations()
        {
            return _db;
        }
        public async Task AddLocations(Location location)
        {
             _db.Add(location);
        }
       

    }
}
