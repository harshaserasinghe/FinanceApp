using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core.DTOs
{
    public class ContactExpenseDto
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
