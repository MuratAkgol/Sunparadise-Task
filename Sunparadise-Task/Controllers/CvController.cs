using Microsoft.AspNetCore.Mvc;

namespace Sunparadise_Task.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Egitim()
        {
            return View();
        }
        public IActionResult Deneyim()
        {
            return View();
        }
        public IActionResult Sertifikalar()
        {
            return View();
        }
    }
}
