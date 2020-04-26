using Finance.Core.Entities;

namespace Finance.Core.DTOs
{
    public class TransactionSummaryDto
    {
        public TranType TranType { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
