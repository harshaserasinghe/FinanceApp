using Finance.Core.DTOs;
using System.Collections.Generic;

namespace Finance.Service
{
    public interface IContactService
    {
        void AddContact(CreateContactDTO createContactDTO);
        ContactDTO GetContact(int contactId);
        List<ContactDTO> GetContacts();
        List<ContactDTO> GetContactsByName(string name);
        void UpdateContact(int contactId, UpdateContactDTO updateContactDTO);
    }
}