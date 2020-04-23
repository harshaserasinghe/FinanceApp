using Finance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core.DTOs
{
    public class TransactionSummaryDto
    {
        public TranType TranType { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
