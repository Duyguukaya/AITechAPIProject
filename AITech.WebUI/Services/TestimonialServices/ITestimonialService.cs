using AITech.WebUI.DTOs.TestimonialDtos;

namespace AITech.WebUI.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto> GetByAsync(int id);
        Task CreateAsync(CreateTestimonialDto testimonialDto);
        Task UpdateAsync(UpdateTestimonialDto testimonialDto);
        Task DeleteAsync(int id);
    }
}
