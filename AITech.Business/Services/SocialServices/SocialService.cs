using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.SocialServices
{
    public class SocialService(ISocialRepository _socialRepository,IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createDto)
        {
            var socials = createDto.Adapt<Social>();
            await _socialRepository.CreateAsync(socials);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TDeleteAsync(int id)
        {
           var social = await _socialRepository.GetByIdAsync(id);
            if (social is null)
            {
                throw new Exception("Sosay Medya Hesapları Bulunamadı.");
            }
            _socialRepository.Delete(social);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<List<ResultSocialDto>> TGetAllAsync()
        {
            var social = await _socialRepository.GetAllAsync();
            return social.Adapt<List<ResultSocialDto>>();
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            return social.Adapt<ResultSocialDto>();
        }

        public async Task TUpdateAsync(UpdateSocialDto updateDto)
        {
            var social = updateDto.Adapt<Social>();
            _socialRepository.Update(social);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
