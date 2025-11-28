using AITech.DTO.CategoryDtos;

namespace AITech.DTO.ProjectDtos
{
    public record class UpdateProjectDto(int Id, string Title, string ImageUrl, int CategoryId);
    
}
