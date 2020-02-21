using System.Collections.Generic;

namespace Finance.Core.Entities
{
    public class RecurringTransaction
    {
        public RecurringTransaction()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int TranRecId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Frequency Frequency { get; set; }

        public ICollection<Transaction> Transactions { get; private set; }
    }
}
