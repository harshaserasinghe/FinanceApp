using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Finance.Service
{
    public class ContactService : IContactService
    {
        private FinanceDbContext FinanaceDbContext { get; set; }
        private IMapper Mapper { get; set; }

        public ContactService()
        {
            FinanaceDbContext = new FinanceDbContext();
            Mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public ContactDTO GetContact(int contactId)
        {
            var contact = FinanaceDbContext.Contacts.Find(contactId);
            var contactDTO = Mapper.Map<ContactDTO>(contact);
            return contactDTO;
        }

        public List<ContactDTO> GetContacts()
        {
            var contacts = FinanaceDbContext.Contacts.Where(c => c.IsActive).ToList();
            var contactDTOs = Mapper.Map<List<ContactDTO>>(contacts);
            return contactDTOs;
        }

        public List<ContactDTO> GetContactsByName(string name)
        {
            var contacts = FinanaceDbContext.Contacts
                .Where(c => c.IsActive && c.Name.Contains(name))
                .OrderBy(c => c.Name)
                .ToList();
            var contactDTOs = Mapper.Map<List<ContactDTO>>(contacts);
            return contactDTOs;
        }

        public void AddContact(CreateContactDTO createContactDTO)
        {
            var contact = Mapper.Map<Contact>(createContactDTO);
            FinanaceDbContext.Contacts.Add(contact);
            FinanaceDbContext.SaveChanges();
        }

        public void UpdateContact(int contactId, UpdateContactDTO updateContactDTO)
        {
            var contact = FinanaceDbContext.Contacts.Find(contactId);
            Mapper.Map(updateContactDTO, contact);
            FinanaceDbContext.Entry(contact).State = EntityState.Modified;
            FinanaceDbContext.SaveChanges();
        }
    }
}

