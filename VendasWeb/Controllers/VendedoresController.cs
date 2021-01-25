using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb.Models;
using VendasWeb.Services;

namespace VendasWeb.Controllers
{
    public class VendedoresController : Controller
    {
        public readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Vendedor vendendor)
        {
            _vendedorService.Insert(vendendor);
            return RedirectToAction(nameof(Index));
        }
    }
}
