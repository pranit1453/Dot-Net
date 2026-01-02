using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Project.Models;
using WebAPI_Project.Services;

namespace WebAPI_Project.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(User user)
        {
            bool status = _service.Validate(user.Username, user.Password);
            return status ? RedirectToAction("GetAllProducts", "Products") : RedirectToAction("Login", "Login");
        }
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(User user)
        {
            bool status = _service.RegisterUser(user);

            if (status)
            {
                TempData["Message"] = "Account Created Successfully";
            }
            else
            {
                TempData["Message"] = "Account not Created";
            }

            return RedirectToAction("Login", "Login");
        }
        [HttpGet]
        public IActionResult Logout() => View();
        
    }
}
