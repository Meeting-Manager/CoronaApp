using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
   public interface ILocationBusinessLogic
    {
        public Task<List<Location>> GetLocationByCity(string city);

        public Task<List<Location>> GetLocation();


    }
}
