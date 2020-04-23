using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Service
{
    public class ReportService
    {
        public FinanceDbContext finanaceDbContext { get; }
        public Mapper mapper { get; }

        public ReportService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }
        public List<TransactionSummaryDto> GetTranSum(int userId, DateTime fromDate, DateTime toDate)
        {

            var tranSumDto = finanaceDbContext.Transactions
                .Where(t => t.IsActive && t.UserId == userId &&
                DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
                DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate))
                .GroupBy(t => t.TranType)
                .Select(t => new TransactionSummaryDto
                {
                    TranType = t.Key,
                    TotalAmount = t.Sum(x => x.Amount)
                })
                .ToList();

            return tranSumDto;
        }

        public List<ContactExpenseBreakDownDto> GetContExpBrkDwn(int userId, DateTime fromDate, DateTime toDate)
        {
            var ContExpDto = finanaceDbContext.Transactions
               .Where(t => t.IsActive && t.UserId == userId && t.TranType == TranType.Debet &&
               DbFunctions.TruncateTime(t.TranDate) >= DbFunctions.TruncateTime(fromDate) &&
               DbFunctions.TruncateTime(t.TranDate) <= DbFunctions.TruncateTime(toDate))
               .GroupBy(t => new { t.Contact.ContactId, t.Contact.Name })
               .Select(t => new ContactExpenseBreakDownDto
               {
                   ContactId = t.Key.ContactId,
                   Name = t.Key.Name,
                   TotalAmount = t.Sum(x => x.Amount)
               })
               .ToList();

            return ContExpDto;
        }

        public List<TransactionByDateDto> GetTranByDate(int userId, DateTime fromDate, DateTime toDate)
        {
            var tranDetailsDtos = finanaceDbContext.Transactions
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
              .ToList();

            return tranDetailsDtos;
        }

    }
}
