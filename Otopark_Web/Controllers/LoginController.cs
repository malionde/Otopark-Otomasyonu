using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Otopark_Otomasyon.BLL;
using System.Web.Security;

namespace Otopark_Web.Controllers
{
    public class LoginController : Controller
    {   
        HizmetRepository hizmetBilgileriRepository = new HizmetRepository();
        [_SessionController]
        public ActionResult Dashboard()
        {
            List<Hizmet> hizmetBilgisi = hizmetBilgileriRepository.Select();
            return View(hizmetBilgisi);
        }

        [_SessionController]
        public ActionResult LoginPage()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        AdminRepository adminRepository = new AdminRepository();
        [AllowAnonymous]
        [HttpPost]
        public ActionResult LoginPage(Admin model, string returnurl)
        {
            if (ModelState.IsValid)
            {
                List<Admin> adminBilgileri = adminRepository.Select();
                //Aşağıdaki if komutu gönderilen mail ve şifre doğrultusunda kullanıcı kontrolu yapar. Eğer kullanıcı var ise login olur.
                var kullanici = adminBilgileri.Where(a => a.Email == model.Email && a.Password == model.Password);
                if (kullanici.Count() > 0)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    Session["Kullanici"] = kullanici;
                    return RedirectToAction("Dashboard", "Login");
                }
                else
                {
                    ModelState.AddModelError("", "Email veya şifre hatalı!");
                }
            }
            return View(model);
        }
        public ActionResult Delete(int hizmetId)
        {
            List<Hizmet> hizmetBilgileri = hizmetBilgileriRepository.Select();
            hizmetBilgileriRepository.Delete(hizmetId);
            return RedirectToAction("Dashboard");
        }

        public ActionResult Edit(int hizmetId)
        {
            //List<Hizmet> hizmetBilgileri = hizmetBilgileriRepository.Select();
            List<Hizmet> hizmetBilgileri = hizmetBilgileriRepository.Select();
            var DuzenlenecekHizmet = hizmetBilgileri.Where(s => s.Id == hizmetId).FirstOrDefault();
            return View(DuzenlenecekHizmet);
        }
        [HttpPost]
        public ActionResult Edit(int hizmetId, Hizmet GuncellenecekHizmet)
        {
            try
            {
                List<Hizmet> hizmetBilgileri = hizmetBilgileriRepository.Select();
                //Değiştirilecek eski ilk nesne
                var DuzenlenecekHizmet = hizmetBilgileri.Where(s => s.Id == hizmetId).FirstOrDefault();
                //Eski nesnemizi güncellenmişi ile değiştiriyoruz.
                UpdateModel(DuzenlenecekHizmet, "");

                hizmetBilgileriRepository.Insert(DuzenlenecekHizmet);
                return RedirectToAction("Dashboard");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        } 
    }
}