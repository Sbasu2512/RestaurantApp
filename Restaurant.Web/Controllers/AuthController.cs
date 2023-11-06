using Microsoft.AspNetCore.Mvc;
using Restaurant.Web.Models;
using Restaurant.Web.Service.IService;

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
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
