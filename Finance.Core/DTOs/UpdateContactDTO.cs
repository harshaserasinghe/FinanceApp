﻿namespace Finance.Core.DTOs
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string BusinessType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
