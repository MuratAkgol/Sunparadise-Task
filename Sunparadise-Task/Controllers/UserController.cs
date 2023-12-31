﻿using BussinesLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Runtime.InteropServices;
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
        CvTablosu _cvtable;

        IsIlaniManager _isler = new IsIlaniManager();
        IsIlanı _is;

        DeneyimManager _deneyimler = new DeneyimManager();
        Deneyim _deneyim;

        EgitimManager _egitimler = new EgitimManager();
        Egitim _egitim;

        BasvuruManager _basvurular = new BasvuruManager();
        Basvuru _basvuru;

        [HttpGet]
        public IActionResult Aday()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Aday(User user)
        {
            var control = db.Users.SingleOrDefault(x => x.Email == user.Email && x.Sifre == user.Sifre);
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
        public IActionResult CvOlustur()
        {
            var cvid = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).CvId;
            var result = db.DeneyimTablosu.Where(x => x.CvTablosuId == cvid).ToList();
            if (cvid != 0 )
            {
                ViewBag.lise = db.EgitimTablosu.FirstOrDefault(x=>x.CvTablosuId == cvid)?.Lise;
                ViewBag.universite = db.EgitimTablosu.FirstOrDefault(x=>x.CvTablosuId == cvid)?.Universite;
                ViewBag.bolum = db.EgitimTablosu.FirstOrDefault(x=>x.CvTablosuId == cvid)?.Bolum;
                ViewBag.Id = db.EgitimTablosu.FirstOrDefault(x=>x.CvTablosuId == cvid)?.Id;

            }
            return View(result);

        }

        [HttpPost]
        public IActionResult Deneyim(Deneyim cvtbl, CvTablosu cv, User usr)
        {
            var isim = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).Isim;
            var soyad = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).SoyAd;
            string isimSoyisim = isim + " " + soyad;
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
            }
            return RedirectToAction("CvOlustur");
        }
        [HttpPost]
        public IActionResult Egitim(Egitim egtm, CvTablosu cv,User usr)
        {
            var isim = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).Isim;
            var soyad = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId).SoyAd;
            string isimSoyisim = isim + " " +soyad;
            var control = db.CvTablosu.FirstOrDefault(x => x.IsimSoyisim == isimSoyisim);

            usr = db.Users.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId);

            if (control == null)
            {
                cv.IsimSoyisim = isimSoyisim;
                _cv.Add(cv);
                egtm.CvTablosuId = cv.Id;
                _egitimler.Add(egtm);
                usr.CvId = cv.Id;
                _users.Update(usr);

            }
            else
            {
                var id = db.CvTablosu.FirstOrDefault(x => x.IsimSoyisim == isimSoyisim).Id;
                egtm.CvTablosuId = id;
                _egitimler.Add(egtm);
            }
            return RedirectToAction("CvOlustur");
        }

        public IActionResult EgitimSil(int id)
        {
            _egitim = _egitimler.GetById(id);
            _egitimler.Delete(_egitim);
            return RedirectToAction("CvOlustur");
        }
        public IActionResult DeneyimSil(int id)
        {
            _deneyim = _deneyimler.GetById(id);
            _deneyimler.Delete(_deneyim);
            return RedirectToAction("CvOlustur");
        }
        public IActionResult Index()
        {
            var result = db.IsIlanlari.OrderByDescending(x => x.ID).ToList();
            var BasvuranCvId = db.BasvuruTablosu.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId)?.BasvuranCvId;
            var IsId = db.BasvuruTablosu.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId)?.IsId;
            ViewBag.BasvuranCvId = BasvuranCvId;
            ViewBag.IsId = IsId;



            return View(result);


        }
        public IActionResult Basvur(Basvuru bsvr)
        {
            var BasvuranCvId = db.BasvuruTablosu.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId)?.BasvuranCvId;
            var IsId = db.BasvuruTablosu.FirstOrDefault(x => x.Id == GlobalDeğişkenler.GirisId)?.IsId;
            
            bsvr.IsId = bsvr.Id;
            bsvr.Id = 0;
            bsvr.BasvuranCvId = db.Users.FirstOrDefault(x=>x.Id == GlobalDeğişkenler.GirisId).CvId;

            if (db.BasvuruTablosu.Any(x=>x.BasvuranCvId == bsvr.BasvuranCvId && x.IsId == bsvr.IsId))
            {
                TempData["AlertMessage"] = "Daha onceden bu ilana basvuru gonderdin!";
                return RedirectToAction("Index");
            }
            _basvurular.Add(bsvr);
            return RedirectToAction("Index");
        }
    }
}
