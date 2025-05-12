using ApplicationService.User.Contract;
using ApplicationService.User.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Endpoint.Controllers
{
    [Route("api/province")]
    [ApiController]
    public class CityController(ICustomerManagmentService customerManagmentService) : ControllerBase
    {
        [HttpGet("list")]
        public async Task<List<CityDto>> GetAllCities()
            => await customerManagmentService.GetAllCitiesAsync();
    }
}
