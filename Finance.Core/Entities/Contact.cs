using System.Collections.Generic;

namespace Finance.Core.Entities
{
    public class Contact
    {
        public Contact()
        {
            IsActive = true;
            Transactions = new HashSet<Transaction>();
        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Transaction> Transactions { get; private set; }
    }
}
