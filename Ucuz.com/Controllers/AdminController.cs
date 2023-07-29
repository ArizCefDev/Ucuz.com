using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
	public class AdminController : Controller
	{
		private readonly IProductService _productService;

		public AdminController(IProductService productService)
		{
			_productService = productService;
		}

		public IActionResult Index()
		{
			var values=_productService.GetAll();
			return View(values);
		}
	}
}
