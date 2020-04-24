using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core.DTOs
{
    public class ForecastDto
    {
        public int TranId { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
    }
}
