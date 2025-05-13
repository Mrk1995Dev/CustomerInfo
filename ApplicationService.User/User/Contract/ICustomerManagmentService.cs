using ApplicationService.User.Dtos;
using ApplicationService.User.Implementation;

namespace ApplicationService.User.Contract
{
    public interface ICustomerManagmentService
    {
        Task<ResultDto<List<CustomerListDto>>> GetCustomerListAsync();
        Task<ResultDto> AddCustomerInfoAsync(AddCustomerInfoDto addCustomerInfoDto);
        Task<ResultDto> DeleteCustomerInfoAsync(int customerId);
        Task<ResultDto> UpdateCustomerInfo(UpdateCustomerInfoDto updateCustomerInfoDto);
        Task<ResultDto<CustomerInfoDetailsDto>> GetCustomerInfoDetailAsync(int customerId);
        Task<ResultDto<byte[]>> ExportCustomerInfoAsync();
        Task<List<CityDto>> GetAllCitiesAsync();
    }
}