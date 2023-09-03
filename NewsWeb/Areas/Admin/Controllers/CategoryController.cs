using Microsoft.AspNetCore.Mvc;

namespace NewsWeb.Areas.Admin.Controllers
{
	public class CategoryController : Controller
	{
		[Area("Admin")]
		public IActionResult Index()
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
