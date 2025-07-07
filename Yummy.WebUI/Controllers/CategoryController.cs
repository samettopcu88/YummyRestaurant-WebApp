using Microsoft.AspNetCore.Mvc;

namespace Yummy.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
