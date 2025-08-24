using Microsoft.AspNetCore.Mvc;

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
		public IActionResult SingUp()
		{
			return View();
		}
	}
}
