using MechanicWebService.Data;
using MechanicWebService.Models;
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

        [HttpPost]
        public IActionResult Create([FromForm] Car carViewModel)
        {
            if (ModelState.IsValid)
            {
                var car = new Car()
                {
                    Model = carViewModel.Model,
                    Mark = carViewModel.Mark,
                    VIN = carViewModel.VIN,
                    Year = carViewModel.Year,
                };
                _context.Cars.Add(car);
                _context.SaveChanges();
            }
            return View(carViewModel);
        }

    }
}
