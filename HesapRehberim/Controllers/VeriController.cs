using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HesapRehberim.Models.Context;
using HesapRehberim.Models.Modeller;

namespace HesapRehberim.Controllers
{
    public class VeriController : Controller
    {
        DatabaseContext db = new DatabaseContext();




        public ActionResult FiyatIstemeR()
        {
            ViewBag.dosyano = db.YaklasikMaliyet.Where(x => x.IsTanimi.dosyaNo == "2021/1")
                .Select(x => x.IsTanimi.dosyaNo).FirstOrDefault();
            ViewBag.konu = db.YaklasikMaliyet.Where(x => x.ID == 1).Select(x => x.IsTanimi.YaklasikMaliyet.konu).FirstOrDefault();
            ViewBag.metin = db.YaklasikMaliyet.Where(x => x.ID == 1).Select(x => x.IsTanimi.YaklasikMaliyet.metin).FirstOrDefault();
            ViewBag.malzemeler = db.Malzemeler.Where(x => x.IsTanimi.dosyaNo == "2021/1").ToList();
            ViewBag.toplam = db.Malzemeler.Where(x => x.IsTanimi.dosyaNo == "2021/1").Sum(x=>x.miktari);
            return View();
        }
    }
}