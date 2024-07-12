using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yt_Dot6Identity.Models.DTO;
using Yt_Dot6Identity.Repositories.Abstract;

namespace Yt_Dot6Identity.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private readonly IUserAuthenticationService _service;
        public UserAuthenticationController(IUserAuthenticationService service)
        {
            this._service = service;
        }
        
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            model.Role = "user";
            var result = await _service.RegisterAsync(model);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _service.LoginAsync(model);
            if (result.StatusCode == 1)
            {
                return RedirectToAction("Display", "Dashboard");
            }
            else
            {
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await this._service.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

        public async Task<IActionResult> reg()
        {
            var model = new RegistrationModel
            {
                Username = "admin",
                FirstName = "Max",
                LastName = "wells",
                Email = "max@gmail.com",
                Password = "Admin@12345#"
            };
            model.Role = "user";
            var result = await _service.RegisterAsync(model);
            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = await _service.ChangePasswordAsync(model, User.Identity.Name);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(ChangePassword));
        }
    }
}
