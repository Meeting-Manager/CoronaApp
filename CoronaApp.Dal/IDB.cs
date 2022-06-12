using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public interface IDB
    {
        public Task<List<Location>> GetLocations();

        public Task AddLocations(Location location);
    }
}
