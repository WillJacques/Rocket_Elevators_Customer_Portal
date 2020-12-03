using ClientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPortal.Controllers
{
    public class InterventionsController : Controller
    {
        public IActionResult New()
        {
            return View();
        }
    }
}
