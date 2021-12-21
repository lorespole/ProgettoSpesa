using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgettoSpesa.Data;
using ProgettoSpesa.EF;
using ProgettoSpesa.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProgettoSpesa.Controllers
{
    public class SpesaController : Controller
    {
        private readonly ILogger<SpesaController> _logger;
        private SpesaContext _context;

        public SpesaController(ILogger<SpesaController> logger, SpesaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            SpesaListViewModel model = new SpesaListViewModel();
            var lista = _context.TListaSpesa.Where(x => true).ToList();
            foreach(var liste in lista)
            {
                SpesaViewModel s = new SpesaViewModel();
                s.Id = liste.Id;
                s.Prodotto = liste.Prodotto;
                s.Quantita = liste.Quantita;
                if (s.Quantita == 0)
                {
                    return RedirectToAction("Error", "Shared");
                }
                s.Prezzo = liste.Prezzo;
                model.SpesaLista.Add(s);
            }
            return View("Spesa", "Index");
        }
        public IActionResult Add(SpesaViewModel model)
        {
            if (ModelState.IsValid)
            {
                TListaSpesa listaSpesa = new TListaSpesa();
                listaSpesa.Id = model.Id;
                listaSpesa.Prodotto = model.Prodotto;
                listaSpesa.Quantita = model.Quantita;
                if (listaSpesa.Quantita == 0)
                {
                    return RedirectToAction("Error", "Shared");
                }
                listaSpesa.Prezzo = model.Prezzo;
                _context.Add(listaSpesa);
                _context.SaveChanges();
            } 
            else
            {
                ModelState.AddModelError("Model", "Errore nella richiesta, riprovare!");
            }
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult DeleteAll()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
