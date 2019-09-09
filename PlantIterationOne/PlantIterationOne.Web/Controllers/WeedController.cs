using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlantIterationOne.Web.Controllers
{
    public class WeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WeedProblem()
        {
            return View(); ; 
        }

        public IActionResult WeedPrevention()
        {
            return View();
        }

        public IActionResult WeedRemoval()
        {
            return View();
        }

        public IActionResult WeedDisposal()
        {
            return View();
        }

        public IActionResult WeedReport()
        {
            return View();
        }
    }
}