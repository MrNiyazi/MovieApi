using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
	public class MoviController : Controller
	{
		public IActionResult MoviList()
		{
			ViewBag.v1 = "Film Listesi";
			ViewBag.v2 = "Ana Sayfa";
			ViewBag.v3 = "Filimler";
			return View();
		}
	}
}
