using MechanicWebService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MechanicWebService.Controllers
{
    public class RentalController : Controller
    {
        private readonly AppDbContext _context;
        public RentalController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ToList=_context.Cars.ToList();
            return View(ToList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
