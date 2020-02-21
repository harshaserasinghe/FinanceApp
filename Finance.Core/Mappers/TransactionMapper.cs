using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;

namespace Finance.Core.Mappers
{
    public class TransactionMapper : Profile
    {
        public TransactionMapper()
        {
            CreateMap<CreateTransaction, Transaction>();
        }
    }
}
