using Finance.Core.Entities;
using System;

namespace Finance.Core.DTOs
{
    public class CreateTransactionDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TranType TranType { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
        public int ContactId { get; set; }
        public bool IsRecurring { get; set; }
        public Frequency Frequency { get; set; }
        public int UserId { get; set; }
    }
}
