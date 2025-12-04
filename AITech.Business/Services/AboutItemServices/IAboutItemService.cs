using AITech.Business.Services.GenericServices;
using AITech.DTO.AboutItem;

namespace AITech.Business.Services.AboutItemServices
{
    public interface IAboutItemService : IGenericService<ResultAboutItemDto, CreateAboutItemDto, UpdateAboutItemDto>
    {
    }
}
