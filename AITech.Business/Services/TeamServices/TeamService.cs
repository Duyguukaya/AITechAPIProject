using AITech.DataAccess.Repositories.TeamRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TeamDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.TeamServices
{
    public class TeamService(ITeamRepository _teamRepository,IUnitOfWork _unitOfWork) : ITeamService
    {
        public async Task TCreateAsync(CreateTeamDto createDto)
        {
            var team = createDto.Adapt<Team>();
            await _teamRepository.CreateAsync(team);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            if (team == null)
            {
                throw new Exception("Takım arkadaşı bulunamadı");
            }
            _teamRepository.Delete(team);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<List<ResultTeamDto>> TGetAllAsync()
        {
            var teams = await _teamRepository.GetAllAsync();
            return teams.Adapt<List<ResultTeamDto>>();
        }

        public async Task<ResultTeamDto> TGetByIdAsync(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            return team.Adapt<ResultTeamDto>();
        }

        public async Task TUpdateAsync(UpdateTeamDto updateDto)
        {
           var team = updateDto.Adapt<Team>();
              _teamRepository.Update(team);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
