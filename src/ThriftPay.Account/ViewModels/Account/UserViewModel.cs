using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftPay.Account.ViewModels.Account
{
    public class UserViewModel
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
