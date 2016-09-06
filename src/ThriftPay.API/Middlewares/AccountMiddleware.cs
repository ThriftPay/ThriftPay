using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace ThriftPay.API.Middlewares
{
    public class AccountMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public AccountMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<AccountMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("Checking for account of authorized user.");

            if(context.User != null)
            {
                var userId = context.User.FindFirstValue("id");

                string account = null;

                if(account == null)
                {
                    // create account
                }
            }

            await _next.Invoke(context);
        }
    }
}
