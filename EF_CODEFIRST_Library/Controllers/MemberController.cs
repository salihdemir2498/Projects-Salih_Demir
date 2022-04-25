using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CODEFIRST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_CODEFIRST.Controllers
{

    public class MemberController : Controller
    {
        private readonly Library6Context _context;

        public MemberController(Library6Context context)
        {
            _context = context;
        }

          public IActionResult Index()
        {
            return View(_context.Members.ToList());
        }

         public IActionResult Details(int id)
        {
            var member = _context.Members.Find(id);
            return View(member);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            _context.Add(member);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult Edit(int id)
        {
            var member = _context.Members.Find(id);
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            if (ModelState.IsValid)  //true dönüyorsa herşey yolunda
            {
                _context.Update(member); //Bu satır sadece contextimizi güncelledi.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(member);
        }

        public IActionResult Delete(int id)
        {
            var category = _context.Members.Find(id);
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var member = _context.Members.Find(id);
            member.IsDeleted = true;
            _context.Update(member);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}