using Restaurant.Web.Models;

namespace Restaurant.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto);
        Task<ResponseDto> RegisterAsync(RegistrationRequestDto obj);
    }
}
