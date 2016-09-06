using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriftPay.Account.Models;
using ThriftPay.Account.ViewModels.Account;

namespace ThriftPay.Account.ViewModels.Mappers
{
    public static class Mappers
    {
        public static UserViewModel ToViewModel(this ApplicationUser source)
        {
            if(source == null)
            {
                return null;
            }

            var destination = new UserViewModel()
            {
                Username = source.UserName
            };

            return destination;
        }
    }
}
