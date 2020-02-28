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
    public class TransactionService : ITransactionService
    {
        public FinanceDbContext FinanaceDbContext { get; private set; }
        public IMapper Mapper { get; private set; }

        public TransactionService()
        {
            FinanaceDbContext = new FinanceDbContext();
            Mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public TransactionDTO GetTransactionById(int id)
        {
            var transaction = FinanaceDbContext.Transactions
                .Include(t => t.Contact)
                .Include(t => t.RecurringTransaction)
                .FirstOrDefault(t => t.TranId == id);

            if (transaction == null)
            {
                return new TransactionDTO();
            }

            var tranDTO = Mapper.Map<TransactionDTO>(transaction);
            return tranDTO;
        }

        public List<TransactionDTO> GetTransactionsByDate(DateTime fromDate, DateTime toDate)
        {
            var transactions = FinanaceDbContext.Transactions.Include(t => t.Contact)
                .Include(t => t.RecurringTransaction)
                .Where(t => DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate)
                    && DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate))
                .OrderBy(t => t.TranDate)
                .ToList();

            if (transactions == null)
            {
                return new List<TransactionDTO>();
            }

            var traDTOs = Mapper.Map<List<TransactionDTO>>(transactions);
            return traDTOs;
        }

        public void AddTransaction(CreateTransactionDTO transactionDTO)
        {
            var transaction = Mapper.Map<Transaction>(transactionDTO);

            if (transactionDTO.IsRecurring)
            {
                var recurringTransaction = Mapper.Map<RecurringTransaction>(transactionDTO);
                FinanaceDbContext.RecurringTransactions.Add(recurringTransaction);
                transaction.RecurringTransaction = recurringTransaction;
            }

            FinanaceDbContext.Transactions.Add(transaction);
            FinanaceDbContext.SaveChanges();
        }

        public void UpdateTransaction(UpdateTransactionDTO transactionDTO)
        {
            var tranEntity = FinanaceDbContext.Transactions.Find(transactionDTO.TranId);
            var updatedTranEntity = Mapper.Map<Transaction>(transactionDTO);
            updatedTranEntity.Contact = FinanaceDbContext.Contacts.Find(transactionDTO.ContactId);
            FinanaceDbContext.Entry(updatedTranEntity).State = EntityState.Modified;
            FinanaceDbContext.Entry(updatedTranEntity.Contact).State = EntityState.Unchanged;
            FinanaceDbContext.SaveChanges();
        }
    }
}
