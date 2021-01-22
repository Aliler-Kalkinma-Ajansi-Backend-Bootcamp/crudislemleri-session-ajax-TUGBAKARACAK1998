using Microsoft.AspNetCore.Mvc;
using ProjeTKToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeTKToDo.Controllers
{
    public class MusterilerController : Controller
    {
        public IActionResult Index()
        {

            Data.Services.MusteriService mstr = new Data.Services.MusteriService();

            return View(mstr.Hepsi());
        }

      //[HttpGet]
      //  public IActionResult Musteri(int? id)
      //  {
      //      var deger = new Data.Models.Musteriler();
      //      if(id.HasValue && id < 0)
      //      {

        //        Data.Services.MusteriService service = new Data.Services.MusteriService();
        //        deger = service.GetById(id.Value);
        //    }
            
        //    return View(deger);

        //}
        //[HttpPost]
        //public IActionResult Musteri(Data.Models.Musteriler musteriler)
        //{


        //    Data.Services.MusteriService musteriService = new Data.Services.MusteriService();
        //    var result = musteriService.Ekle(musteriler);
        //    if (result > 0)
        //    {
        //        return RedirectToAction("Ekle",new { id = result });
        //    }

        //    return View();
        //}


    }
}
