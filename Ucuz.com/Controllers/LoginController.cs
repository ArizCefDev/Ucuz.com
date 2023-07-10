using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult SignIn()
		{
			return View();
		}

		public IActionResult SignUp()
		{
			return View();	
		}
	}
}
