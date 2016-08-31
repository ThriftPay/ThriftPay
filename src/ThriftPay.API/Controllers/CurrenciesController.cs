using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftPay.API.Controllers
{
    [Route("currencies")]
    public class CurrenciesController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult GetCurrencies()
        {
            return Ok();
        }
    }
}
