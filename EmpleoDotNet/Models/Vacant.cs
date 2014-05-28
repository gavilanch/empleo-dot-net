using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpleoDotNet.Models
{
    public class Vacant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}