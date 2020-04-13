using System.Collections.Generic;

namespace Finance.Core.Entities
{
    public class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
            Events = new HashSet<Event>();
            Contacts = new HashSet<Contact>();
        }
        public int UserId { get; set; }
        public string Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Contact> Contacts { get; set; }

    }
}
