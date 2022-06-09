using Microsoft.AspNetCore.Mvc;

namespace PaymentMethod.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Payment");
        }
    }
}