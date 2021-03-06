using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Core.Validators;
using Finance.Data;
using FluentValidation;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Service
{
    public class ContactService
    {
        private readonly FinanceDbContext finanaceDbContext;
        private readonly Mapper mapper;
        private readonly CreateContactValidator createContVal;
        private readonly UpdateContactValidator updateContVal;

        public ContactService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
            createContVal = new CreateContactValidator();
            updateContVal = new UpdateContactValidator();
        }

        public ContactDto GetCont(int contId)
        {
            var cont = finanaceDbContext.Contacts.Find(contId);
            var contDto = mapper.Map<ContactDto>(cont);
            return contDto;
        }

        public List<ContactDto> GetConts()
        {
            var conts = finanaceDbContext.Contacts.Where(c => c.IsActive).ToList();
            var contDtos = mapper.Map<List<ContactDto>>(conts);
            return contDtos;
        }

        public List<ContactDto> GetContsByName(string name)
        {
            var contQuery = finanaceDbContext.Contacts
                .Where(c => c.IsActive).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                contQuery = contQuery.Where(c => c.Name.Contains(name)).AsQueryable();
            }

            var conts = contQuery.OrderBy(c => c.Name).ToList();

            var contDtos = mapper.Map<List<ContactDto>>(conts);
            return contDtos;
        }

        public void AddCont(CreateContactDto createContDto)
        {
            createContVal.ValidateAndThrow(createContDto);

            var cont = mapper.Map<Contact>(createContDto);

            finanaceDbContext.Contacts.Add(cont);
            finanaceDbContext.SaveChanges();

            var path = Path.Combine(FileService.ContFilePath, $"cont_{cont.ContactId.ToString()}.xml");
            Task.Run(() => FileService.SaveOrUpdateEntityToFile(cont, path));
        }

        public void UpdateContact(UpdateContactDto updateContDto)
        {
            updateContVal.ValidateAndThrow(updateContDto);

            var cont = finanaceDbContext.Contacts.Find(updateContDto.ContactId);

            mapper.Map(updateContDto, cont);

            finanaceDbContext.Entry(cont).State = EntityState.Modified;
            finanaceDbContext.SaveChanges();

            var path = Path.Combine(FileService.ContFilePath, $"cont_{cont.ContactId.ToString()}.xml");
            Task.Run(() => FileService.SaveOrUpdateEntityToFile(cont, path));
        }

        public void DeleteCont(int contId)
        {
            var cont = finanaceDbContext.Contacts.Find(contId);
            finanaceDbContext.Contacts.Remove(cont);
            finanaceDbContext.SaveChanges();

            var path = Path.Combine(FileService.ContFilePath, $"cont_{cont.ContactId.ToString()}.xml");
            Task.Run(() => FileService.DeleteEntityFile(path));
        }
    }
}

