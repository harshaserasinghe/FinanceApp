using Finance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core.DTOs
{
    public class TransactionByDateDto
    {
        public TranType TranType { get; set; }
        public DateTime TranDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
