using AITech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AITech.WebUI.Validators.Project
{
    public class CreateProjectValidator : AbstractValidator<CreateProjectDto> 
    {
        public CreateProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz")
                                 . MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Url boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz");
        }
    }
}
