using ApplicationService.User.Contract;
using ApplicationService.User.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Endpoint.Controllers
{
    [Route("api/customer/")]
    [ApiController]
    [AllowAnonymous]
    public class CustomerController(
        ICustomerManagmentService customerManagmentService) : ControllerBase
    {
        [HttpGet("info")]
        public async Task<ResultDto<CustomerInfoDetailsDto>> CustomerInfo([FromQuery] int id)
            => await customerManagmentService.GetCustomerInfoDetailAsync(id);

        [HttpGet("customerList")]
        public async Task<IActionResult> GetListCustomerInfo()
        {
            var data = await customerManagmentService.GetCustomerListAsync();
            if (data.IsSuccess)
                return Ok(data.Data);

            return NotFound(data);
        }

        [HttpPost("addCustomer")]
        public async Task<IActionResult> AddCustomerInfo([FromBody] AddCustomerInfoDto customerInfo)
        {
            var result = await customerManagmentService.AddCustomerInfoAsync(customerInfo);

            if (result.IsSuccess) return Created();

            return NotFound(result);
        }

        [HttpPut("edit")]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerInfoDto updateCustomer)
        {
            var data = await customerManagmentService.UpdateCustomerInfo(updateCustomer);
            if (data.IsSuccess) return Ok(data);

            return BadRequest(data);
        }

        [HttpDelete("remove")]
        public async Task<IActionResult> DeleteCustomer([FromQuery] int id)
        {
            var data = await customerManagmentService.DeleteCustomerInfoAsync(id);
            if (data.IsSuccess) return Ok();

            return NotFound(data);
        }

        [HttpGet("export")]
        public async Task<IActionResult> ExportCustomerInfo()
        {
            var data = await customerManagmentService.ExportCustomerInfoAsync();
            if (!data.IsSuccess) return NotFound();

            return File(data.Data, "text/palin", "CustomerInfoReport.txt");
        }
    }
}
