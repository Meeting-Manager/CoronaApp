using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Tests
{
    public class PatientsControllerTests
    {
        private readonly WebApplicationFactory<Program> application = new WebApplicationFactory<Program>();

        [Fact]
        public async Task GetPatientByID_returnPatientID()
        {
            // Arrange
            var client = application.CreateClient();
            // Act
            var response = await client.GetAsync("/api/Patients/1");
            // Assert
            response.EnsureSuccessStatusCode();
        }
        [Fact]
        public async Task PostPatients()
        {
           var obj= new{
          city="Jerusalem",
          startDate=new DateTime(),
          endDate=new DateTime(),
          theLocation="ffff",
               patientId =new{
                id="1"
            }
            };
           JsonContent content=JsonContent.Create(obj);
            // Arrange
            var client = application.CreateClient();
            // Act
            var response = await client.PostAsync("/api/Patients",content);
            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
