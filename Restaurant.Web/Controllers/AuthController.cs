using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Web.Models;
using Restaurant.Web.Service.IService;
using Restaurant.Web.Utility;

namespace Restaurant.Web.Controllers
{
    public class AuthController : Controller
    {
        //dependency injection being consumed here ==> injecting auth service for  login/register.
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text=ApiTypeEnum.RoleAdmin, Value=ApiTypeEnum.RoleAdmin},
                new SelectListItem{Text=ApiTypeEnum.RoleCustomer, Value=ApiTypeEnum.RoleCustomer}
            };

            ViewBag.RoleList = roleList;

            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
