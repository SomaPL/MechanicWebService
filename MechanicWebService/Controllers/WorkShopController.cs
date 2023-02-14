using MechanicWebService.Data;
using MechanicWebService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MechanicWebService.Controllers
{
    [Authorize]
    public class WorkShopController : Controller
    {
        private readonly AppDbContext _context;
        public WorkShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var ToList = _context.ServiceRequests.ToList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create([FromForm] ServiceRequest serviceViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var servicerequest = new ServiceRequest()
        //        {
        //            Title = serviceViewModel.Title,
        //            Description = serviceViewModel.Description,
        //            Model = serviceViewModel.Model,
        //            Mark = serviceViewModel.Mark,
        //            VIN = serviceViewModel.VIN,
        //            Year = serviceViewModel.Year,
        //        };
        //        _context.ServiceRequests.Add(servicerequest);
        //        _context.SaveChanges();
        //    }
        //    return View(serviceViewModel);
        //}
    }
}
