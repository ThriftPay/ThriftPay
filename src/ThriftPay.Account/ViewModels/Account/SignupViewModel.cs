using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftPay.Account.ViewModels.Account
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "The username property is required.")]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password property is required.")]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
