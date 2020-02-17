using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aegis.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class WorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}