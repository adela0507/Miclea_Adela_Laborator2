using Miclea_Adela_Laborator2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Miclea_Adela_Laborator2.Data;
using Miclea_Adela_Laborator2.Models.LibraryViewModels;


namespace Miclea_Adela_Laborator2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Statistics()
        {
            IQueryable<OrderGroup> data =
            from order in _context.Orders
            group order by order.OrderDate into dateGroup
            select new OrderGroup()
            {
                OrderDate = dateGroup.Key,
                BookCount = dateGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }


        private readonly ILogger<HomeController> _logger;
        private readonly LibraryContext _context;
      

        public HomeController(ILogger<HomeController> logger, LibraryContext context)
        {
            _context = context;
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}