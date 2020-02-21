using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;

namespace Finance.Service
{
    public class TransactionService : ITransactionService
    {
        public FinanceDbContext FinanaceDbContext { get; private set; }
        public IMapper Mapper { get; private set; }

        public TransactionService(FinanceDbContext finanaceDbContext, IMapper mapper)
        {
            FinanaceDbContext = finanaceDbContext;
            Mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public void AddTransaction(CreateTransaction transactionDTO)
        {
            var transaction = Mapper.Map<Transaction>(transactionDTO);
            FinanaceDbContext.Transactions.Add(transaction);
            FinanaceDbContext.SaveChanges();
        }
    }
}
