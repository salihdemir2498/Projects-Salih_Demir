using DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>
            {
                new Article {ID=1, Header="CSS Flexbox Kullanımı" , Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, iure voluptas quidem veritatis vitae est illum cum beatae quam maxime."},
                new Article {ID=2, Header="C#'ta Döngüler" , Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, iure voluptas quidem veritatis vitae est illum cum beatae quam maxime."},
                new Article {ID=3, Header="Değişken Nedir?" , Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, iure voluptas quidem veritatis vitae est illum cum beatae quam maxime."},
                new Article {ID=4, Header="MVC Yapısının Temelleri" , Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, iure voluptas quidem veritatis vitae est illum cum beatae quam maxime."},
                new Article {ID=5, Header="React Nedir?" , Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, iure voluptas quidem veritatis vitae est illum cum beatae quam maxime."},
                new Article {ID=6, Header="JavaScript Diziler?" , Content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas, iure voluptas quidem veritatis vitae est illum cum beatae quam maxime."},
            };
            return View(articles);
        }
    }
}
