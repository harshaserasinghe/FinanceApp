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
    public class ReportService
    {
        private readonly FinanceDbContext finanaceDbContext;
        private readonly Mapper mapper;

        public ReportService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }
        public List<TransactionSummaryDto> GetTranSumry(int userId, DateTime fromDate, DateTime toDate)
        {

            var tranSumryDtos = finanaceDbContext.Transactions
                .Where(t => t.IsActive && t.UserId == userId &&
                DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
                DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate))
                .GroupBy(t => t.TranType)
                .Select(t => new TransactionSummaryDto
                {
                    TranType = t.Key,
                    TotalAmount = t.Sum(x => x.Amount)
                })
                .OrderBy(t => t.TranType)
                .ToList();

            return tranSumryDtos;
        }

        public List<ExpenseByContactDto> GetExpnBrkDwnByCont(int userId, DateTime fromDate, DateTime toDate)
        {
            var expnByContDtos = finanaceDbContext.Transactions
               .Where(t => t.IsActive && t.UserId == userId && t.TranType == TranType.Debit &&
               DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
               DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate))
               .GroupBy(t => new { t.Contact.ContactId, t.Contact.Name })
               .Select(t => new ExpenseByContactDto
               {
                   ContactId = t.Key.ContactId,
                   Name = t.Key.Name,
                   TotalAmount = t.Sum(x => x.Amount)
               })
               .OrderBy(t => t.Name)
               .ToList();

            return expnByContDtos;
        }

        public List<TransactionByDateDto> GetTranBrkDownByDate(int userId, DateTime fromDate, DateTime toDate)
        {
            var tranByDateDtos = finanaceDbContext.Transactions
              .Where(t => t.IsActive && t.UserId == userId &&
              DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
              DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate))
              .GroupBy(t => new { t.TranType, DbFunctions.TruncateTime(t.TranDate).Value })
              .Select(t => new TransactionByDateDto
              {
                  TranType = t.Key.TranType,
                  TranDate = t.Key.Value,
                  TotalAmount = t.Sum(x => x.Amount)
              })
              .OrderBy(t => new { t.TranDate, t.TranType })
              .ToList();

            return tranByDateDtos;
        }

    }
}
