using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PlantIterationOne.Web.Model;
using PlantIterationOne.Web.Services;
using PlantIterationOne.Web.ViewModels;

namespace PlantIterationOne.Web.Controllers
{
    public class PlantController : Controller
    {

        private readonly INativeService _nativeService;
        private readonly IInvasiveService _invasiveService;


        public PlantController(INativeService nativeService,
            IInvasiveService invasiveService)
        {
            _nativeService = nativeService;
            _invasiveService = invasiveService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public async Task<IActionResult> InvasiveList()
        {
            var invasives = await _invasiveService.GetAllAsync();
            return View(invasives);
        }

        public async Task<IActionResult> InvasiveDetail(int id)
        {
            var invasive = await _invasiveService.GetByIdAsync(id);
            if (invasive == null)
            {
                return RedirectToAction(nameof(Category));
            }
            return View(invasive);
        }

        public async Task<IActionResult> InvasiveEdit(int id)
        {
            var model = await _invasiveService.GetByIdAsync(id); ;
            if (model == null)
            {
                return RedirectToAction(nameof(Category));
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> InvasiveEdit(int id,
            InvasiveViewModel invasiveViewModel)
        {
            var invasie = await _invasiveService.GetByIdAsync(id);

            if (invasie == null)
            {
                return View(invasie);
            }

            try
            {
                invasie.Name = invasiveViewModel.Name;
                invasie.ImageUrl = invasiveViewModel.ImageUrl;
                await _invasiveService.UpdateAsync(invasie);
                return RedirectToAction(nameof(Category));
            }
            catch
            {
                return View(invasiveViewModel);
            }


            /**
            try
            {
                var fileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "/vicplant/wwwroot/images", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                model.ImageUrl = fileName;
                model.Name = invasive.Name;
                await _invasiveService.UpdateAsync(model);
                return RedirectToAction(nameof(Category));
            }
            catch
            {
                return View(invasive);
            }
    */
        }







        public async Task<IActionResult> NativeList()
        {
            var natives = await _nativeService.GetAllAsync();
            return View(natives);
        }

        public async Task<IActionResult> NativeDetail(int id)
        {
            var native = await _nativeService.GetByIdAsync(id);
            if (native == null)
            {
                return RedirectToAction(nameof(Category));
            }
            return View(native);
        }

        public async Task<IActionResult> NativeEdit(int id)
        {
            var model = await _nativeService.GetByIdAsync(id); ;
            if (model == null)
            {
                return RedirectToAction(nameof(Category));
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NativeEdit(int id,
            NativeUpdateViewModel nativeUpdateViewModel )
        {
            var native = await _nativeService.GetByIdAsync(id);

            if (native == null)
            {
                return View(native);
            }

            try
            {
                native.Name = nativeUpdateViewModel.Name;
                native.ImageUrl = nativeUpdateViewModel.ImageUrl;
                await _nativeService.UpdateAsync(native);
                return RedirectToAction(nameof(Category));
            }
            catch
            {
                return View(nativeUpdateViewModel);
            }

        }
    }
}