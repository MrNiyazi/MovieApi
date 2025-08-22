using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
	public class RegisterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
