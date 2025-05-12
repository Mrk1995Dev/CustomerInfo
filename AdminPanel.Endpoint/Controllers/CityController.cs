using ApplicationService.Location.Contract;
using Domain.Location;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Endpoint.Controllers
{
    [Route("api/city")]
    [ApiController]
    [AllowAnonymous]
    public class CityController(ICityService cityService) : ControllerBase
    {
        [HttpPost("addNewCity")]
        public async Task<bool> AddCity(List<City> cities)
            => await cityService.AddRangeCityAsync(cities);
    }
}
