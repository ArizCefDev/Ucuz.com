using Business.Abstract;
using DataAccess.Entity;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;

namespace Ucuz.com.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        //Elave et

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MessageDTO p)
        {
            _messageService.Insert(p);
            return RedirectToAction("MessageShow");
        }

        public IActionResult MessageShow()
        {
            return View();  
        }
    }
}
