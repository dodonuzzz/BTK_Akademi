using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTK_Akademi.Models;

namespace BTK_Akademi.Controllers
{
    public class KursController : Controller
    {
        // GET: Kurs
        public ActionResult Index()
        {
            var model = Repository.Applications.ToList();
            return View(model);
        }

        public ActionResult Başvur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Başvur(CandidateModel model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "İkinci bir kursa başvuru yapamazsın.");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            else
            {
                // Doğrulama hatalarını ekleyin
                //if (string.IsNullOrEmpty(model.Email))
                //{
                //    ModelState.AddModelError("Email", "Email'i boş bırakamazsın.");
                //}
                //if (string.IsNullOrEmpty(model.Ad))
                //{
                //    ModelState.AddModelError("Ad", "İsmin ne dostum?");
                //}
                //if (string.IsNullOrEmpty(model.Soyad))
                //{
                //    ModelState.AddModelError("Soyad", "Soyadı Kanunu 1934'te yürürlüğe girmedi mi?");
                //}
                // Diğer alanlar için doğrulama hatalarını ekleyin
                return View(model);
            }
        }


        public ActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Feedback(CandidateModel model)
        {
            string ad = model.Ad;
            string soyad = model.Soyad;
            return View(model);
        }



    }
}
