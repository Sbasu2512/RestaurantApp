using Restaurant.Web.Models;

namespace Restaurant.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> Register(RegistrationRequestDto registrationRequestDto);
        Task<ResponseDto?> AssignRoleASync(RegistrationRequestDto registrationRequestDto);

    }
}
