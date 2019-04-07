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
            if (id <= bandsService.GetAllBands().Length)
                return View(bandsService.GetBandById(id));
            else
                return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            bandsService.AddBand();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            bandsService.AddBand();
            return View();
        }
    }
}