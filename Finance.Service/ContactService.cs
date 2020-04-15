using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Finance.Service
{
    public class ContactService
    {
        private readonly FinanceDbContext finanaceDbContext;
        private readonly Mapper mapper;

        public ContactService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
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
            var cont = mapper.Map<Contact>(createContDto);
            finanaceDbContext.Contacts.Add(cont);
            finanaceDbContext.SaveChanges();
        }

        public void UpdateContact(UpdateContactDto updateContDto)
        {
            var cont = finanaceDbContext.Contacts.Find(updateContDto.ContactId);
            mapper.Map(updateContDto, cont);
            finanaceDbContext.Entry(cont).State = EntityState.Modified;
            finanaceDbContext.SaveChanges();
        }

        public void DeleteCont(int contId)
        {
            var cont = finanaceDbContext.Contacts.Find(contId);
            finanaceDbContext.Contacts.Remove(cont);
            finanaceDbContext.SaveChanges();
        }
    }
}

