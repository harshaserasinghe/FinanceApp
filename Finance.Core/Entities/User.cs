using System.Collections.Generic;
using System.Xml.Serialization;

namespace Finance.Core.Entities
{
    public class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
            Events = new HashSet<Event>();
        }
        public int UserId { get; set; }
        public string Name { get; set; }

        [XmlIgnore]
        public ICollection<Transaction> Transactions { get; set; }
        [XmlIgnore]
        public ICollection<Event> Events { get; set; }

    }
}
