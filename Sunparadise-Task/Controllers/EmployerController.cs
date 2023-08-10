using BussinesLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Sunparadise_Task.Controllers
{
    public class EmployerController : Controller
    {
        Context db = new Context();

        EmployerManager _employers = new EmployerManager();
        Employer _employer;

        CvManager _cv = new CvManager();
        CvTable _cvtlb;

        [HttpGet]
        public IActionResult Isveren()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Isveren(Employer emp)
        {
            var control = db.Employers.SingleOrDefault(x => x.Eposta == emp.Eposta && x.Sifre == emp.Sifre);
            if (control != null)
            {
                GlobalDeğişkenler.GirisId = db.Users.FirstOrDefault(x => x.Email == emp.Eposta).Id;
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UyeOl(Employer emp)
        {
            var control = db.Employers.FirstOrDefault(x=>x.Eposta == emp.Eposta);
            if (control == null)
            {
                _employers.Add(emp);
                return RedirectToAction("Isveren");
            }
            else
            {
                return RedirectToAction("UyeOl");
            }
            
        }
        public IActionResult CvGoruntule()
        {
            var result = _cv.List();
            return View(result);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
