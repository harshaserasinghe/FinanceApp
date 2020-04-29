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
                cfg.CreateMap<CreateTransactionDto, Transaction>();
                cfg.CreateMap<CreateEventDto, Event>();

                cfg.CreateMap<Transaction, TransactionDto>()
                .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.Contact.Name))
                .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.RecurringTransaction.Frequency));

                cfg.CreateMap<Event, EventDto>()
                .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.Contact.Name))
                .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.RecurringEvent.Frequency));

                cfg.CreateMap<UpdateTransactionDto, Transaction>();
                cfg.CreateMap<UpdateEventDto, Event>();

                cfg.CreateMap<Contact, ContactDto>();

                cfg.CreateMap<CreateTransactionDto, RecurringTransaction>()
               .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.Frequency));

                cfg.CreateMap<CreateEventDto, RecurringEvent>()
               .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.Frequency));

                cfg.CreateMap<UpdateTransactionDto, RecurringTransaction>()
               .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.Frequency));

                cfg.CreateMap<UpdateEventDto, RecurringEvent>()
               .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.Frequency));

                cfg.CreateMap<CreateContactDto, Contact>();
                cfg.CreateMap<UpdateContactDto, Contact>();

                cfg.CreateMap<User, UserDto>();
            });
        }
    }
}
