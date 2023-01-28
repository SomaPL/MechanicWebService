using Microsoft.AspNetCore.Mvc;

namespace MechanicWebService.Controllers
{
    public class WorkShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
