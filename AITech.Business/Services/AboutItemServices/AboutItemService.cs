using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutItem;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutItemServices
{
    public class AboutItemService(IAboutItemRepository _aboutItemRepository, IUnitOfWork _unitOfWork) : IAboutItemService
    {
        public async Task TCreateAsync(CreateAboutItemDto createDto)
        {
            var about = createDto.Adapt<AboutItem>();
            await _aboutItemRepository.CreateAsync(about);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var about = await _aboutItemRepository.GetByIdAsync(id);
            if (about is null)
            {
                throw new Exception("Hakkımızda  bulunamadı");
            }
            _aboutItemRepository.Delete(about);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<List<ResultAboutItemDto>> TGetAllAsync()
        {
            var about = await _aboutItemRepository.GetAllAsync();
            return about.Adapt<List<ResultAboutItemDto>>();
        }

        public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
        {
            var about = await _aboutItemRepository.GetByIdAsync(id);
            return about.Adapt<ResultAboutItemDto>();
        }

        public async Task TUpdateAsync(UpdateAboutItemDto updateDto)
        {
            var about = updateDto.Adapt<AboutItem>();
            _aboutItemRepository.Update(about);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
