using Microsoft.AspNetCore.Mvc;

namespace LMS.api.Controllers
{
    public class SprintController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
