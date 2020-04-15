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
        public FinanceDbContext finanaceDbContext { get; }
        public Mapper mapper { get; }

        public TransactionService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public TransactionDto GetTran(int tranId, int userId)
        {
            var tran = finanaceDbContext.Transactions
                .Include(t => t.Contact)
                .Include(t => t.RecurringTransaction)
                .FirstOrDefault(t => t.TranId == tranId && t.UserId == userId);

            if (tran == null)
            {
                return new TransactionDto();
            }

            var tranDto = mapper.Map<TransactionDto>(tran);
            return tranDto;
        }

        public List<TransactionDto> GetTransByDate(int userId, TranType tranType, DateTime fromDate, DateTime toDate)
        {
            var tranQuery = finanaceDbContext.Transactions
                .Include(t => t.Contact)
                .Include(t => t.RecurringTransaction)
                .AsQueryable();

            if (TranType.All != tranType)
            {
                tranQuery = tranQuery.Where(t => t.TranType == tranType).AsQueryable();
            }

            tranQuery = tranQuery.Where(t => t.IsActive &&
                t.UserId == userId &&
                DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
                DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate)).AsQueryable();

            var trans = tranQuery.OrderBy(t => t.TranDate).ToList();

            if (trans == null)
            {
                return new List<TransactionDto>();
            }

            var tranDtos = mapper.Map<List<TransactionDto>>(trans);
            return tranDtos;
        }

        public void AddTran(CreateTransactionDto createTranDto)
        {
            var tran = mapper.Map<Transaction>(createTranDto);

            if (createTranDto.IsRecurring)
            {
                var recTran = mapper.Map<RecurringTransaction>(createTranDto);
                finanaceDbContext.RecurringTransactions.Add(recTran);
                tran.RecurringTransaction = recTran;
            }

            finanaceDbContext.Transactions.Add(tran);
            finanaceDbContext.SaveChanges();
        }

        public void UpdateTran(UpdateTransactionDto updateTranDto)
        {
            var tran = finanaceDbContext.Transactions.Find(updateTranDto.TranId);
            mapper.Map(updateTranDto, tran);

            if (updateTranDto.IsRecurring)
            {
                var recTran = finanaceDbContext.RecurringTransactions.Find(updateTranDto.TranRecId);
                mapper.Map(updateTranDto, recTran);
                finanaceDbContext.Entry(recTran).State = EntityState.Modified;
            }

            finanaceDbContext.Entry(tran).State = EntityState.Modified;
            finanaceDbContext.SaveChanges();
        }

        public void DeleteTran(int tranId)
        {
            var tran = finanaceDbContext.Transactions.Find(tranId);
            finanaceDbContext.Transactions.Remove(tran);
            finanaceDbContext.SaveChanges();
        }


        public List<RecurringTransactionDto> GetRecurringTransactions()
        {
            var recurringTransactions = finanaceDbContext.RecurringTransactions
                .Where(rt => rt.IsActive).Select(rt => new RecurringTransactionDto
                {
                    TranRecId = rt.TranRecId,
                    Frequency = rt.Frequency,
                    Transaction = rt.Transactions.OrderByDescending(t => t.TranDate).FirstOrDefault()
                })
                .ToList();

            return recurringTransactions;
        }

        public void HandleRecurringTransactions(List<RecurringTransactionDto> recurringTransactionDTOs)
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

        private void AddTracsaction(RecurringTransactionDto recurringTransaction)
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
            finanaceDbContext.Transactions.Add(transaction);
            finanaceDbContext.SaveChanges();
        }

        private bool HasDaliy(RecurringTransactionDto recurringTransaction, DateTime currentDate)
        {
            return finanaceDbContext.Transactions
                .Any(t => t.TranRecId == recurringTransaction.TranRecId &&
                DbFunctions.TruncateTime(t.TranDate) == DbFunctions.TruncateTime(currentDate));
        }

        private bool HasMonthly(RecurringTransactionDto recurringTransaction, DateTime monthStartDate, DateTime monthEndDate)
        {
            return finanaceDbContext.Transactions
                .Any(t => t.TranRecId == recurringTransaction.TranRecId &&
                DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(monthStartDate) &&
                DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(monthEndDate));
        }
    }
}
