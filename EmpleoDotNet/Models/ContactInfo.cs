using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpleoDotNet.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string CompanyLogo { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string WebAddress { get; set; }
        public Address Address { get; set; }
    }
}