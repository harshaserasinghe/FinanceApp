using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Mappers;
using Finance.Data;
using System.Collections.Generic;
using System.Linq;

namespace Finance.Service
{
    public class ContactService
    {
        private FinanceDbContext FinanaceDbContext { get;  set; }
        private IMapper Mapper { get; set; }

        public ContactService()
        {
            FinanaceDbContext = new FinanceDbContext();
            Mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public List<ContactDTO> GetContacts()
        {
            var contacts = FinanaceDbContext.Contacts.Where(c => c.IsActive).ToList();
            var contactDTOs = Mapper.Map<List<ContactDTO>>(contacts);
            return contactDTOs;
        }
    }
}
