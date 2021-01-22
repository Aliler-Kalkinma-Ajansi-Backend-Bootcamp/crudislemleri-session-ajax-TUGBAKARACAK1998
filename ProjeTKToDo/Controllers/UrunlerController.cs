using Microsoft.AspNetCore.Mvc;
using ProjeTKToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeTKToDo.Controllers
{
    public class UrunlerController : Controller
    {

        public IActionResult Index()
        {

            Data.Services.UrunlerService urun = new Data.Services.UrunlerService();

            return View(urun.Hepsi());
        }

        public IActionResult UrunEkle()
        {
            return View(new UrunEkleModel());
        }

        [HttpPost]
        public IActionResult UrunEkle(UrunEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Data.Services.UrunlerService service = new Data.Services.UrunlerService();
                Data.Models.Urunler urun = new Data.Models.Urunler();


                service.Ekle(new Data.Models.Urunler
                {


                    Urunad = model.Ad,
                    UrunMarka = model.Marka,
                    UrunFiyat = model.Fiyat,
                    UrunKategori = model.Kategori,
                    UrunStokSayisi = model.StokSayisi

                });

                return RedirectToAction("Index");

            }




            return View(model);

        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {

            Data.Services.UrunlerService service = new Data.Services.UrunlerService();
            var gelenUrun = service.GetirIdile(id);
            UrunGuncelleModel model = new UrunGuncelleModel
            {

                Ad = gelenUrun.Urunad,
                Marka = gelenUrun.UrunMarka,
                Kategori = Convert.ToInt32(gelenUrun.UrunKategori),
                Fiyat = gelenUrun.UrunFiyat,
                StokSayisi = gelenUrun.UrunStokSayisi,
                Id = gelenUrun.UrunId,




            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(UrunGuncelleModel model)
        {
            Data.Models.Urunler urun = new Data.Models.Urunler();
            Data.Services.UrunlerService service = new Data.Services.UrunlerService();

            var ktgr = service.GetirIdile(model.Id);
            if (ModelState.IsValid)
            {
           
                ktgr.Urunad = model.Ad;
                ktgr.UrunMarka = model.Marka;
                ktgr.UrunKategori = model.Kategori;
                ktgr.UrunFiyat = model.Fiyat;
                ktgr.UrunStokSayisi = model.StokSayisi;
                service.Guncelle(ktgr);
                return RedirectToAction("Index");

            }

            return View(model);
        }




        public IActionResult Sil(int id)
        {
            Data.Services.UrunlerService service = new Data.Services.UrunlerService();
            service.Sil(new Data.Models.Urunler { UrunId = id });
            return RedirectToAction("Index");
        }


    }
}
