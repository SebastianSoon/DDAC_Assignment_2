using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Testing.Models;
using DDAC_Testing.Data;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Testing.Controllers
{
    public class FlowersController : Controller
    {
        private readonly DDAC_TestingContext _context;
        public FlowersController(DDAC_TestingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddData()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
        AddData([Bind("FlowerName,FlowerProducedDate,FlowerType,FlowerPrice")] Flower flower)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flower);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flower);
        }

    }
}
