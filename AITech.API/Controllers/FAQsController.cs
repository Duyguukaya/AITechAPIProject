using AITech.Business.Services.FAQSercives;
using AITech.DTO.FAQDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController(IFAQServive _fAQServive) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var faq = await _fAQServive.TGetAllAsync();
            return Ok(faq);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var faq = await _fAQServive.TGetByIdAsync(id);
            return Ok(faq);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFAQDto fAQDto)
        {
           await _fAQServive.TCreateAsync(fAQDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFAQDto fAQDto)
        {
            await _fAQServive.TUpdateAsync(fAQDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _fAQServive.TDeleteAsync(id);
            return NoContent();
        }

    }
}
