using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.ViewComponents.Contact.Footer
{
    public class AddressList : ViewComponent
    {
        private readonly IContactService _contactService;

        public AddressList(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetAll();
            return View(values);
        }
    }
}
