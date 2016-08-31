using Microsoft.AspNetCore.Mvc;

namespace ThriftPay.Account.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
