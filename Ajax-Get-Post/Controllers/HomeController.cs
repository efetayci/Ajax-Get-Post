using Ajax_Get_Post.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ajax_Get_Post.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            Thread.Sleep(5000);
            var jsonKullanicilar = JsonConvert.SerializeObject(KullaniciIslem.GetirHepsi());
            return Json(jsonKullanicilar);
        }
        public JsonResult GetById(int id)
        {
            var kullanıcı = KullaniciIslem.GetirIdile(id);
            var jsonKullanici = JsonConvert.SerializeObject(kullanıcı);
            return Json(jsonKullanici);
        }
        [HttpPost]
        public IActionResult Add(Kullanici kullanici)
        {
            KullaniciIslem.Ekle(kullanici);
            var json = JsonConvert.SerializeObject(kullanici);
            return Json(json);
        }


    }

   
}
