using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilingualGamoDictionary.Controllers
{
    public class WordController : Controller
    {        
        public IActionResult Index([FromHeader]string myName)
        {
            return Json(new { My = myName});
        }
    }
}
