using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.ViewComponents.Contact
{
	public class MapList : ViewComponent
	{
		private readonly IContactService _contactService;

		public MapList(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _contactService.GetAll();
			return View(value);
		}
	}
}
