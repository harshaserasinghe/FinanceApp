using System.Collections.Generic;

namespace Finance.Core.Entities
{
    public class Contact
    {
        public Contact()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Transaction> Transactions { get; private set; }
    }
}
