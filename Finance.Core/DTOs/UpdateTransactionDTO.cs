using AutoMapper.Configuration.Annotations;
using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class UpdateTransactionDTO
    {
        public int TranId { get; set; }
        public string Name { get; set; }
        public TranType TranType { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsRecurring { get; set; }
        public int ContactId { get; set; }
    }
}
