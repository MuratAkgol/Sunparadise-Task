using BussinesLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Sunparadise_Task.Controllers
{
    public class CvController : Controller
    {
        Context db = new Context();

        UserManager _users = new UserManager();
        User _user;

        Employer _employers = new Employer();
        Employer _employer;

        CvManager _cv = new CvManager();
        CvTablosu _cvtable;

        IsIlaniManager _isler = new IsIlaniManager();
        IsIlanı _is;

        DeneyimManager _deneyimler = new DeneyimManager();
        Deneyim _deneyim;

        public IActionResult Egitim()
        {
            return View();
        }
        public IActionResult Deneyim()
        {
            return RedirectToAction("CvOlustur", "UserController");
        }
        [HttpPost]
        public IActionResult Deneyim(Deneyim cvtbl, CvTablosu cv, User usr)
        {
            var isim = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).Isim;
            var soyad = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).SoyAd;
            string isimSoyisim = isim + soyad;
            var control = db.CvTablosu.FirstOrDefault(x => x.IsimSoyisim == isimSoyisim);

            usr = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId);

            if (control == null)
            {
                cv.IsimSoyisim = isimSoyisim;
                _cv.Add(cv);
                cvtbl.CvTablosuId = cv.Id;
                _deneyimler.Add(cvtbl);
                usr.CvId = cv.Id;
                _users.Update(usr);

            }
            else
            {
                var id = db.CvTablosu.FirstOrDefault(x => x.IsimSoyisim == isimSoyisim).Id;
                cvtbl.CvTablosuId = id;
                _deneyimler.Add(cvtbl);

                usr.CvId = cv.Id;
                _users.Update(usr);
            }
            return RedirectToAction("CvOlustur", "UserController");
            //return View();
        }
        public IActionResult Sertifikalar()
        {
            return View();
        }
    }
}
