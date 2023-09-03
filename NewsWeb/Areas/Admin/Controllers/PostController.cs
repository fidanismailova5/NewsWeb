using Microsoft.AspNetCore.Mvc;

namespace NewsWeb.Areas.Admin.Controllers
{
    public class PostController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
