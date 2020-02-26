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
                .ForMember(dest => dest.TranRecName, opt => opt.MapFrom(src => src.RecurringTransaction.Name))
                .ForMember(dest => dest.Frequency, opt => opt.MapFrom(src => src.RecurringTransaction.Frequency));

                cfg.CreateMap<UpdateTransactionDTO, Transaction>()
                .ForMember(dest => dest.TranId, opt => opt.Ignore());
            });
        }
    }
}
