using AITech.Business.Services.GenericServices;
using AITech.DTO.TeamDtos;

namespace AITech.Business.Services.TeamServices
{
    public interface ITeamService:IGenericService<ResultTeamDto,CreateTeamDto,UpdateTeamDto>
    {
    }
}
