using Microsoft.AspNetCore.Mvc;
using MoviApi.Dto.Dtos.UserRegisterDtos;

namespace MovieApi.WebUI.Controllers
{
	public class RegisterController : Controller
	{
		[HttpGet]
		public IActionResult SingUp()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SingUp(CreateUserRegisterDto createUserRegisterDto)
		{
			return RedirectToAction("SingIn", "Login");
		}
	}
}
