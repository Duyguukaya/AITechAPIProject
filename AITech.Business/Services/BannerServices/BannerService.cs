using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.BannerDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.BannerServices
{
    public class BannerService(IBannerRepository _bannerRepository, IUnitOfWork _unitOfWork) : IBannerService
    {
        public async Task TCreateAsync(CreateBannerDto createDto)
        {
            var banner = createDto.Adapt<Banner>();
            await _bannerRepository.CreateAsync(banner);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            if (banner is null)
            {
                throw new Exception("Banner bulunamadı");
            }
            _bannerRepository.Delete(banner);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<List<ResultBannerDto>> TGetAllAsync()
        {
            var banner = await _bannerRepository.GetAllAsync();
            return banner.Adapt<List<ResultBannerDto>>();
        }

        public async Task<ResultBannerDto> TGetByIdAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            if (banner is null)
            {
                throw new Exception("Banner bulunamadı");
            }
            return banner.Adapt<ResultBannerDto>();
        }

        public async Task TMakeActiveAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            await _bannerRepository.MakeActiveAsync(banner);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TMakePassiveAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            await _bannerRepository.MakePassiveAsync(banner);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TUpdateAsync(UpdateBannerDto updateDto)
        {
            var banner = updateDto.Adapt<Banner>();
            _bannerRepository.Update(banner);
            await _unitOfWork.SaveChangeAsync();

        }
    }
}
