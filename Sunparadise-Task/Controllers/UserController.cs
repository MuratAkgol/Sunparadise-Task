using BussinesLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Sunparadise_Task.Controllers
{
    public class UserController : Controller
    {
        Context db = new Context();

        UserManager _users = new UserManager();
        User _user;

        CvManager _cv = new CvManager();
        CvTable _cvtable;
        
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
                
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("UyeOl");
            }
            
        }
        [HttpPost]
        public IActionResult CVYarat(CvTable cvtbl)
        {
            _cv.Add(cvtbl);

            var user = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId);
            user.CvId = cvtbl.Id;
            _users.Update(user);
            return RedirectToAction("CvOlustur");
        }
        public IActionResult CvOlustur()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
