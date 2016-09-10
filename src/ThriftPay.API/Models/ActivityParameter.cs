using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftPay.API.Models
{
    public class ActivityParameter
    {
        public Guid Id { get; set; }
        public Guid ActivityId { get; set; }
        public string Parameter { get; set; }
        public string Value { get; set; }

        public virtual UserActivity UserActivity { get; set; }
    }
}
