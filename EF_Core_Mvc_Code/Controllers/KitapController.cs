using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Mvc_Code.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}