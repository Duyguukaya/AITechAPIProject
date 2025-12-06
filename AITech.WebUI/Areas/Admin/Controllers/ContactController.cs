using AITech.WebUI.DTOs.ContactDtos;
using AITech.WebUI.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController(IContactService _contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var contacts = await _contactService.GetAllAsync();
            return View(contacts);
        }

        [HttpGet]
        public async Task<IActionResult> CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto contactDto)
        {
            await _contactService.CreateAsync(contactDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var contact = await _contactService.GetByAsync(id);
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto contactDto)
        {
            await _contactService.UpdateAsync(contactDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            await _contactService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
