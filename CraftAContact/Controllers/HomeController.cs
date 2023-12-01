using CraftAContact.Data;
using CraftAContact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CraftAContact.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context; //Added ApplicationDbContext to access Contacts

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context) //Modified parameters to add context
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var username = User.Identity.Name;
                var contacts = await _context.Contacts
                                             .Where(c => c.Username == username)
                                             .Include(c => c.Category)
                                             .ToListAsync();
                return View(contacts);
            }
            else
            {
                // Handle scenario for non-authenticated users, if needed
                return View(new List<Contact>());
            }
        }

        public IActionResult Contacts()
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
