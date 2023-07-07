using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
