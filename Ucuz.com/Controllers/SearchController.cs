using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
	public class SearchController : Controller
	{
		private readonly IProductService _productService;

		public SearchController(IProductService productService)
		{
			_productService = productService;
		}

		public IActionResult Index(string productname)
		{
			var values = from a in _productService.GetAll() select a;
			if (!string.IsNullOrEmpty(productname))
			{
				values = values.Where(p => p.Name.ToLower().Contains(productname.ToLower()));
			}
			return View(values);
		}
	}
}
