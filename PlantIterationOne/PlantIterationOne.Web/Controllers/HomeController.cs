using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantIterationOne.Web.Data;
using PlantIterationOne.Web.Services;

namespace PlantIterationOne.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly PlantContext _context;
        private readonly INativeService _nativeServie;

        public HomeController(PlantContext context, INativeService nativeService)
        {
            _context = context;
            _nativeServie = nativeService;
        }

        public IActionResult Index()
        {
            //DatabaseInitializer.Seed(_context);


            return View();
        }

        public IActionResult Harbour()
        {
            return View(); 
        }

        public IActionResult NativePlants()
        {
            return View(); 
        }

        public IActionResult GardenCare()
        {
            return View();
        }

        public IActionResult VicFlora()
        {
            return View(); 
        }

        public IActionResult About()
        {
            return View(); 
        }

        public IActionResult News()
        {
            return View(); 
        }

        public IActionResult Weather()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View(); 
        }
    }
}