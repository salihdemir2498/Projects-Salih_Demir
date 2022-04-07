using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class HomeArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
