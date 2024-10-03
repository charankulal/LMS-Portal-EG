using Microsoft.AspNetCore.Mvc;

namespace LMS.api.Controllers
{
    public class CertificateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
