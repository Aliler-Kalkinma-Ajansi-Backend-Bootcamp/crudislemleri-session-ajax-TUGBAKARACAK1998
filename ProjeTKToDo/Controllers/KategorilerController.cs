using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeTKToDo.Controllers
{
    public class KategorilerController : Controller
    {
        public IActionResult Index()
        {

            Data.Services.KategoriService ktgr = new Data.Services.KategoriService();

            return View(ktgr.Hepsi());
        }
    }
}
