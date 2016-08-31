using Microsoft.AspNetCore.Mvc;

namespace ThriftPay.API.Controllers
{
    [Route("error")]
    public class ErrorController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult Error()
        {
            return BadRequest();
        }
    }
}
