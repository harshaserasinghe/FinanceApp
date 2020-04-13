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
    public class TransactionService
    {
        private FinanceDbContext FinanaceDbContext { get; set; }
        private IMapper Mapper { get; set; }

        public TransactionService()
        {
            FinanaceDbContext = new FinanceDbContext();
            Mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public TransactionDTO GetTransaction(int transactionId, int userId)
        {
            var transaction = FinanaceDbContext.Transactions
                .Include(t => t.Contact)
                .Include(t => t.RecurringTransaction)
                .FirstOrDefault(t => t.TranId == transactionId && t.UserId == userId);

            if (transaction == null)
            {
                return new TransactionDTO();
            }

            var tranDTO = Mapper.Map<TransactionDTO>(transaction);
            return tranDTO;
        }

        public List<TransactionDTO> GetTransactionsByDate(int userId, TranType tranType, DateTime fromDate, DateTime toDate)
        {
            var transactionQuery = FinanaceDbContext.Transactions
                .Include(t => t.Contact)
                .Include(t => t.RecurringTransaction)
                .AsQueryable();

            if (TranType.Credit == tranType || TranType.Debet == tranType)
            {
                transactionQuery.Where(t => t.TranType == tranType).AsQueryable();
            }

            transactionQuery.Where(t => t.IsActive &&
                t.UserId == userId &&
                DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
                DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate)).AsQueryable();

            var transactions = transactionQuery.OrderBy(t => t.TranDate).ToList();

            if (transactions == null)
            {
                return new List<TransactionDTO>();
            }

            var transactionDTOs = Mapper.Map<List<TransactionDTO>>(transactions);
            return transactionDTOs;
        }

        public void AddTransaction(CreateTransactionDTO createTransactionDTO)
        {
            var transaction = Mapper.Map<Transaction>(createTransactionDTO);

            if (createTransactionDTO.IsRecurring)
            {
                var recurringTransaction = Mapper.Map<RecurringTransaction>(createTransactionDTO);
                FinanaceDbContext.RecurringTransactions.Add(recurringTransaction);
                transaction.RecurringTransaction = recurringTransaction;
            }

            FinanaceDbContext.Transactions.Add(transaction);
            FinanaceDbContext.SaveChanges();
        }

        public void UpdateTransaction(int transactionId, UpdateTransactionDTO updateTransactionDTO)
        {
            var transaction = FinanaceDbContext.Transactions.Find(transactionId);
            Mapper.Map(updateTransactionDTO, transaction);
            FinanaceDbContext.Entry(transaction).State = EntityState.Modified;
            FinanaceDbContext.SaveChanges();
        }

        public List<RecurringTransactionDTO> GetRecurringTransactions()
        {
            var recurringTransactions = FinanaceDbContext.RecurringTransactions
                .Where(rt => rt.IsActive).Select(rt => new RecurringTransactionDTO
                {
                    TranRecId = rt.TranRecId,
                    Frequency = rt.Frequency,
                    Transaction = rt.Transactions.OrderByDescending(t => t.TranDate).FirstOrDefault()
                })
                .ToList();

            return recurringTransactions;
        }

        public void HandleRecurringTransactions(List<RecurringTransactionDTO> recurringTransactionDTOs)
        {
            DateTime currentDate = new DateTime(2020, 04, 01);
            var monthStartDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var monthEndDate = monthStartDate.AddMonths(1).AddDays(-1);
            var yearStartDate = new DateTime(currentDate.Year, 1, 1);
            var yearEndDate = monthStartDate.AddYears(1).AddMonths(-1);

            foreach (var recurringTransaction in recurringTransactionDTOs)
            {
                if (recurringTransaction.Frequency == Frequency.Daliy &&
                    !HasDaliy(recurringTransaction, currentDate))
                {
                    AddTracsaction(recurringTransaction);
                }
                else if (recurringTransaction.Frequency == Frequency.Monthly &&
                    recurringTransaction.Transaction.TranDate.Day == currentDate.Day &&
                    !HasMonthly(recurringTransaction, monthStartDate, monthEndDate))
                {
                    AddTracsaction(recurringTransaction);
                }
                else if (recurringTransaction.Frequency == Frequency.Yearly &&
                    recurringTransaction.Transaction.TranDate.Month == currentDate.Month &&
                    recurringTransaction.Transaction.TranDate.Day == currentDate.Day &&
                    !HasMonthly(recurringTransaction, yearStartDate, yearEndDate))
                {
                    AddTracsaction(recurringTransaction);
                }
            }
        }

        private void AddTracsaction(RecurringTransactionDTO recurringTransaction)
        {
            var transaction = new Transaction();
            transaction.Name = recurringTransaction.Transaction.Name;
            transaction.Description = recurringTransaction.Transaction.Description;
            transaction.TranType = recurringTransaction.Transaction.TranType;
            transaction.TranDate = DateTime.Now;
            transaction.Amount = recurringTransaction.Transaction.Amount;
            transaction.IsRecurring = true;
            transaction.ContactId = recurringTransaction.Transaction.ContactId;
            transaction.TranRecId = recurringTransaction.TranRecId;
            FinanaceDbContext.Transactions.Add(transaction);
            FinanaceDbContext.SaveChanges();
        }

        private bool HasDaliy(RecurringTransactionDTO recurringTransaction, DateTime currentDate)
        {
            return FinanaceDbContext.Transactions
                .Any(t => t.TranRecId == recurringTransaction.TranRecId &&
                DbFunctions.TruncateTime(t.TranDate) == DbFunctions.TruncateTime(currentDate));
        }

        private bool HasMonthly(RecurringTransactionDTO recurringTransaction, DateTime monthStartDate, DateTime monthEndDate)
        {
            return FinanaceDbContext.Transactions
                .Any(t => t.TranRecId == recurringTransaction.TranRecId &&
                DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(monthStartDate) &&
                DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(monthEndDate));
        }
    }
}
