using System.Collections.Generic;
using System.Web.Mvc;
using Otopark_Otomasyon.BLL;
using System.Net.Mail;

namespace Otopark_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Send(FormCollection collection)
        {
                MailMessage mail = new MailMessage();
                mail.To.Add("malionde@gmail.com");  //mail gönderilen adres
                mail.From = new MailAddress("no-replay@atakotoyikama.com");  //maili gönderen adres
                mail.Subject = "İletişim Formu";
                string Body = "İsim Soyisim : " + collection["firstname"] + collection["lastname"] + " </br>Telefon : " + collection["phone"] + " </br>Mesaj : " + collection["message"];
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.UseDefaultCredentials = false;
                // ***********
                smtp.Credentials = new System.Net.NetworkCredential("Email", "Passwords");
                smtp.Port = 587;
                smtp.Send(mail);
            return RedirectToAction("Contact");
        }

        HizmetRepository hizmetBilgileriRepository = new HizmetRepository();
        public ActionResult Blog()
        {
            List<Hizmet> hizmetBilgisi = hizmetBilgileriRepository.Select();
            return View(hizmetBilgisi);
        }
    }
}