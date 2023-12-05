using Microsoft.AspNetCore.Mvc;
using PustokMVC.Contexts;

namespace PustokMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        PustokDBContext _dbContext { get; }

        public BlogController(PustokDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
