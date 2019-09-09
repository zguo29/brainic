using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlantIterationOne.Web.Controllers
{
    public class GardenCareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}