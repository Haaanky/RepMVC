using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepQuiz.Models;

namespace RepQuiz.Controllers
{
    public class BandsController : Controller
    {
        BandsService bandsService;
        public BandsController(BandsService bandsService)
        {
            this.bandsService = bandsService;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View(bandsService.GetAllBands());
        }

        [Route("bands/details")]
        public IActionResult Details()
        {
            return RedirectToAction(nameof(Index));
        }

        [Route("bands/details/{id}")]
        public IActionResult Details(int id)
        {
            //if (id <= bandsService.GetAllBands().Length)
                return View(bandsService.GetBandById(id));
            //else
                //return RedirectToAction(nameof(Index));
        }
        // Uppgift 2 nedan
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (!ModelState.IsValid)
            {
                return View(band);
            }
            bandsService.AddBand(band);
            return RedirectToAction(nameof(Index));
        }

        [Route("bands/edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(bandsService.GetBandById(id));
        }

        [Route("bands/edit/{id}")]
        [HttpPost]
        public IActionResult Edit(Band band)
        {
            if (!ModelState.IsValid)
                return View();

            bandsService.EditBand(band);
            return RedirectToAction(nameof(Index));
        }

        [Route("bands/delete/{id}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(bandsService.GetBandById(id));
        }

        [Route("bands/delete/{id}")]
        [HttpPost]
        public IActionResult Delete(Band band)
        {
            bandsService.DeleteBand(band);
            return RedirectToAction(nameof(Index));
        }
    }
}