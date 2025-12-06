using AITech.Business.Services.GenericServices;
using AITech.DTO.ContactDtos;

namespace AITech.Business.Services.ContactServices
{
    public interface IContactService : IGenericService<ResultContactDto,CreateContactDto,UpdateContactDto>
    {
    }
}
