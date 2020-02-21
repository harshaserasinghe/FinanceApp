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
                cfg.CreateMap<CreateTransaction, Transaction>();

            });
        }
    }
}
