using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftPay.API.Models
{
    public class UserActivity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
