using AITech.DataAccess.Repositories.ContactRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ContactDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.ContactServices
{
    internal class ContactService(IContactRepository _contactRepository,IUnitOfWork _unitOfWork) : IContactService
    {
        public async Task TCreateAsync(CreateContactDto createDto)
        {
            var contact = createDto.Adapt<Contact>();
            await _contactRepository.CreateAsync(contact);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var contact = await _contactRepository.GetByIdAsync(id);
            if (contact is null)
            {
                throw new Exception("Proje bulunamadı");
            }
            _contactRepository.Delete(contact);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<List<ResultContactDto>> TGetAllAsync()
        {
            var contact = await _contactRepository.GetAllAsync();
            return contact.Adapt<List<ResultContactDto>>();
        }

        public async Task<ResultContactDto> TGetByIdAsync(int id)
        {
            var contact = await _contactRepository.GetByIdAsync(id);
            return contact.Adapt<ResultContactDto>();
        }

        public async Task TUpdateAsync(UpdateContactDto updateDto)
        {
            var contact = updateDto.Adapt<Contact>();
            _contactRepository.Update(contact);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
