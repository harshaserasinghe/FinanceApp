using System.Collections.Generic;
using System.Xml.Serialization;

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
        public string BusinessType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        [XmlIgnore]
        public ICollection<Transaction> Transactions { get; private set; }
    }
}
