using Microsoft.AspNetCore.Mvc;

namespace LMS.api.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
