using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;

namespace Finance.Core.Mappers
{
    public class EntityMappingConfig
    {
        public MapperConfiguration mapperConfig { get; set; }

        public EntityMappingConfig()
        {
            mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreateTransactionDTO, Transaction>();

                cfg.CreateMap<Transaction, TransactionDTO>()
                .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.Contact.Name))
                .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.RecurringTransaction.Frequency));

                cfg.CreateMap<UpdateTransactionDTO, Transaction>();

                cfg.CreateMap<Contact, ContactDTO>();

                cfg.CreateMap<CreateTransactionDTO, RecurringTransaction>()
               .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.Frequency));

                cfg.CreateMap<CreateContactDTO, Contact>();
                cfg.CreateMap<UpdateContactDTO, Contact>();
            });
        }
    }
}
