using AITech.DTO.CategoryDtos;

namespace AITech.DTO.ProjectDtos
{
    public record class ResultProjectDto(int Id,string Title, string ImageUrl, int CategoryId, ResultCategoryDto Category);
    
}
