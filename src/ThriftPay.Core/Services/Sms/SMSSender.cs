using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftPay.Core.Services.Sms
{
    public class SmsSender
    {
        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}
