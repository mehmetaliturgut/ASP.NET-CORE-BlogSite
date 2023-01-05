using Microsoft.AspNetCore.Mvc;

namespace UI_Core_BlogSite.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
