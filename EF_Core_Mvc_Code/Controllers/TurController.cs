using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_Mvc_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Core_Mvc_Code.Controllers
{

    public class TurController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public TurController(KutuphaneSabahContext context)
        {
            _context = context;
            //Bu aşamdan sonra yani nesne ilk üretildiği andan itibaren
            //_context değişkeni benim modelimi temsil ediyor olacak.
            //Bir daha yani, KutuphaneSabahContext'i temsil edecek.
        }
        //GET-kİTAP TÜRLERİNİ LİSTELE
        public IActionResult Index()
        {
            return View(_context.Turlers.ToList());
        }
        //GET-Kitap türü detayını göster
        public IActionResult Details(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }

        //GET-Düzenlenecek kitabın bilgilerini göster
        //[HttpGet] default değer yazmaya gerek yok
        public IActionResult Edit(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }

        [HttpPost]
        public IActionResult Edit(Turler tur)
        {
            if (ModelState.IsValid)  //true dönüyorsa herşey yolunda
            {
                _context.Update(tur); //Bu satır sadece contextimizi güncelledi.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tur);
        }

        //GET-Silinecek kitap türü sayfasını getirecek
        public IActionResult Delete(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // var silinecekKitapTuru = _context.Turlers.Find(id);
            _context.Remove(_context.Turlers.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Turler tur)
        {
            _context.Add(tur);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}