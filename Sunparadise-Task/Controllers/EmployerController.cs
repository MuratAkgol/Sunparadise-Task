using BussinesLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Sunparadise_Task.Controllers
{
    public class EmployerController : Controller
    {
        Context db = new Context();

        EmployerManager _employers = new EmployerManager();
        Employer _employer;

        CvManager _cv = new CvManager();
        CvTablosu _cvtlb;

        IsIlaniManager _isler = new IsIlaniManager();
        IsIlanı _is;

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
                GlobalDeğişkenler.GirisId = db.Employers.FirstOrDefault(x => x.Eposta == emp.Eposta).Id;
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
            var cvler = db.CvTablosu.Include(c => c.Deneyimler).ToList();

            return View(cvler);
        }
        [HttpGet]
        public IActionResult IlanOlustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult IlanOlustur(IsIlanı isilani)
        {
            isilani.IsVerenAdi = db.Employers.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).FirmaAdi;
            _isler.Add(isilani);
            return RedirectToAction("Index");
            
        }
        public IActionResult IsIlanlarim()
        {
            var isVerenAdi = db.Employers.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).FirmaAdi;
            var result = db.IsIlanlari.Where(x=>x.IsVerenAdi == isVerenAdi).OrderByDescending(x=>x.ID).ToList();
            return View(result);
        }
        public IActionResult Index()
        {
            var result = db.Employers.Where(x=>x.Id == GlobalDeğişkenler.GirisId).ToList();
            return View(result);
        }
        [HttpPost]
        public IActionResult BilgiGuncelle(Employer emp)
        {
            var sirketHk = emp.FirmaHk;
            emp = db.Employers.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId);
            emp.FirmaHk = sirketHk;
            _employers.Update(emp);
            return RedirectToAction("Index");
        }
    }
}
