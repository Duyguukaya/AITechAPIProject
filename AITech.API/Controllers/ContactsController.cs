using AITech.Business.Services.ContactServices;
using AITech.DTO.ContactDtos;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IContactService _contactService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contact = await _contactService.TGetAllAsync();
            return Ok(contact);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _contactService.TGetByIdAsync(id);
            return Ok(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactDto contactDto)
        {
            await _contactService.TCreateAsync(contactDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateContactDto contactDto)
        {
            await _contactService.TUpdateAsync(contactDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _contactService.TDeleteAsync(id);
            return NoContent();
        }
    }
}
