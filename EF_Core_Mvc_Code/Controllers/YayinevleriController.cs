using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_Mvc_Code.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Mvc_Code.Controllers
{
    public class YayinevleriController : Controller
    {
         private readonly KutuphaneSabahContext _context;

         public YayinevleriController(KutuphaneSabahContext context)
         {
             _context = context;
         }
         
          public IActionResult Index()
        {
            return View(_context.Yayinevleris.ToList());
        }

        public IActionResult Details(int id)
        {
            var yayinevi = _context.Yayinevleris.Find(id);
            return View(yayinevi);
        }
        public IActionResult Edit(int id)
        {
            var yayinevleri = _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }

        [HttpPost]
        public IActionResult Edit(Yayinevleri yayinevi)
        {
            if (ModelState.IsValid)  //true dönüyorsa herşey yolunda
            {
                _context.Update(yayinevi); //Bu satır sadece contextimizi güncelledi.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yayinevi);
        }

         public IActionResult Delete(int id)
        {
            var yayinevleri = _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }

        [HttpPost,ActionName("Delete")]
         public IActionResult DeleteConfirmed(int id)
         {
             var yayinev = _context.Yayinevleris.Find(id);
             _context.Remove(yayinev);
             _context.SaveChanges();
             return RedirectToAction("Index");

         }

    }
}