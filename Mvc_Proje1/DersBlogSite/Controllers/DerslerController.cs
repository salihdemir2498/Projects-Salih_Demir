using DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            //Varsayalım ki bu veriler DATABASE ' den geliyor.
            //Şu an database konusu görmediğimiz için kendimiz verileri ürettik.
            var lessons = new List<Lesson>
            {
                new Lesson {ID=1, LessonName="HTML" , Category="FrontEnd"},
                new Lesson {ID=2, LessonName="CSS" , Category="FrontEnd"},
                new Lesson {ID=3, LessonName="Bootstrap" , Category="FrontEnd"},
                new Lesson {ID=4, LessonName="JavaScript" , Category="FrontEnd"},
                new Lesson {ID=5, LessonName="JQuery" , Category="FrontEnd"},
                new Lesson {ID=6, LessonName="C#" , Category="BackEnd"},
                new Lesson {ID=7, LessonName="PHP" , Category="BackEnd"}

            };
            return View(lessons);
        }
    }
}
