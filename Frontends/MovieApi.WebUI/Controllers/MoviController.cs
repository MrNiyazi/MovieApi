using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
	public class MoviController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public MoviController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public IActionResult MoviList()
		{
			ViewBag.v1 = "Film Listesi";
			ViewBag.v2 = "Ana Sayfa";
			ViewBag.v3 = "Filimler";
			return View();
		}
	}
}
