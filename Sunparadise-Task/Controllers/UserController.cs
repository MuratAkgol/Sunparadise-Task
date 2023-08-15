using BussinesLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.Xml;

namespace Sunparadise_Task.Controllers
{
    public class UserController : Controller
    {
        Context db = new Context();

        UserManager _users = new UserManager();
        User _user;

        Employer _employers = new Employer();
        Employer _employer;

        CvManager _cv = new CvManager();
        CvTable _cvtable;

        IsIlaniManager _isler= new IsIlaniManager();
        IsIlanı _is;
        
        [HttpGet]
        public IActionResult Aday()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Aday(User user)
        {
            var control = db.Users.SingleOrDefault(x=>x.Email == user.Email && x.Sifre == user.Sifre);
            if (control != null)
            {
                GlobalDeğişkenler.GirisId = db.Users.FirstOrDefault(x => x.Email == user.Email).Id;
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
        public IActionResult UyeOl(User user)
        {
            var control = db.Users.FirstOrDefault(x => x.Email == user.Email);
            if (control == null)
            {
                _users.Add(user);
                
                return RedirectToAction("Aday");
            }
            else
            {
                return RedirectToAction("UyeOl");
            }
            
        }
        [HttpGet]
        public IActionResult CvOlustur()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CvOlustur(CvTable cvtbl)
        {
            _cv.Add(cvtbl);

            var user = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId);
            user.CvId = cvtbl.Id;
            _users.Update(user);
            return RedirectToAction("CvOlustur");
        }
        public IActionResult Index()
        {
            var result = db.IsIlanlari.OrderByDescending(x=>x.ID).Take(4).ToList();
            return View(result);
        }
    }
}
