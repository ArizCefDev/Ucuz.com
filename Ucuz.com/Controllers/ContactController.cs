using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
