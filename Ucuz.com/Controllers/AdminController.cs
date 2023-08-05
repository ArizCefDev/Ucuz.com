using Business.Abstract;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
	public class AdminController : Controller
	{
		private readonly IProductService _productService;
		private readonly IMessageService _messageService;
		private readonly IAboutService _aboutService;
		private readonly IContactService _contactService;

		public AdminController(IProductService productService, IMessageService messageService, IAboutService aboutService, IContactService contactService)
		{
			_productService = productService;
			_messageService = messageService;
			_aboutService = aboutService;
			_contactService = contactService;
		}

		public IActionResult Index()
		{
			var values = _productService.GetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(ProductDTO p)
		{
			p.Star = "fa fa-star yellow-star";
			_productService.Insert(p);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Update(int id)
		{
			var values = _productService.GetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult Update(ProductDTO p)
		{
			p.Star = "fa fa-star yellow-star";
			_productService.Update(p);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			_productService.Delete(id);
			return RedirectToAction("Index");
		}

		public IActionResult MessageIndex()
		{
			var values = _messageService.GetAll();
			return View(values);
		}

		public IActionResult MessageDelete(int id)
		{
			_messageService.Delete(id);
			return RedirectToAction("MessageIndex");
		}

		//About
		public IActionResult AboutIndex()
		{
			var values = _aboutService.GetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult AboutUpdate(int id)
		{
			var values = _aboutService.GetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult AboutUpdate(AboutDTO p)
		{
			p.Advantage = "N";
			_aboutService.Update(p);
			return RedirectToAction("AboutIndex");
		}

        //Contact
        public IActionResult ContactIndex()
        {
            var values = _contactService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult ContactUpdate(int id)
        {
            var values = _contactService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ContactUpdate(ContactDTO p)
        {
            _contactService.Update(p);
            return RedirectToAction("AboutIndex");
        }
    }
}
