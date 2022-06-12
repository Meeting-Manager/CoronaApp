using CoronaApp.Controllers;
using CoronaApp.Services;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;

namespace CoronaApp.Tests
{

    public class LocationsControllerTests
        {
      
       private readonly WebApplicationFactory<Program> application = new WebApplicationFactory<Program>();

        [Fact]
        public async Task GetAllLocations_returnLocations()
        {
                // Arrange
                var client = application.CreateClient();
                // Act
                var response = await client.GetAsync("/api/Locations");
             // Assert
                response.EnsureSuccessStatusCode();
        }
        [Fact]
        public async Task GetLocationsByCity_returnLocations()
        {
            var client = application.CreateClient();
            var response = await client.GetAsync("/api/Locations/getByCity?city=Bney Brack");
            response.EnsureSuccessStatusCode();
        }
        [Fact]
        public async Task GetLocationsByCity_byMock_returnLocations()
        {
            var mock = new Mock<ILocationBusinessLogic>();
            List<Location> locations = new List<Location>()
            {
                new Location
                {
                City = "Jerusalem",
                StartDate = new DateTime(),
                EndDate = new DateTime(),
                TheLocation = "ffff",
                PatientId = new Patient()
                {
                    Id = "1"
                }
                }
            };
            mock.Setup(m => m.GetLocationByCity("Bney Brack")).Returns(Task.FromResult(locations));
            var controller = new LocationsController(mock.Object);
            var actual =  controller.getLocationByCity("Bney Brack").Result;
               Assert.Same(actual, locations); 
            
        }
    }
    }
