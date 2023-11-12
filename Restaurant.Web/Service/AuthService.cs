﻿using Restaurant.Web.Models;
using Restaurant.Web.Service.IService;
using Restaurant.Web.Utility;

namespace Restaurant.Web.Service
{
    public class AuthService : IAuthService
    {
        //getting base service using dependency injection
        private readonly IBaseService _baseService;
        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
        {
           
                return await _baseService.SendAsync(new RequestDto()
                {
                    ApiType = ApiTypeEnum.ApiType.POST,
                    Data = registrationRequestDto,
                    Url = ApiTypeEnum.AuthAPIBase + "/api/auth/AssignRole"
                });
            
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.POST,
                Data = loginRequestDto,
                Url = ApiTypeEnum.AuthAPIBase + "/api/auth/login"
            });
        }

        public async Task<ResponseDto?> Register(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.POST,
                Data = registrationRequestDto,
                Url = ApiTypeEnum.AuthAPIBase + "/api/auth/register"
            });
        }

        Task<ResponseDto> IAuthService.RegisterAsync(RegistrationRequestDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
