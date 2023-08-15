using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Sunparadise_Task.Controllers
{
    public class CvController : Controller
    {
        Context db = new Context();
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
