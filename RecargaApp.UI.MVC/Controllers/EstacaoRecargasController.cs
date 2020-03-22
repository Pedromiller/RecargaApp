using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecargaApp.Application.Services;
using RecargaApp.Application.ViewModels;
using RecargaApp.Domain.Aggregates;
using RecargaApp.Infra.Data.Context;

namespace RecargaApp.UI.MVC.Controllers
{
    public class EstacaoRecargasController : Controller
    {
        private readonly IEstacaoRecargaService _estacaoRecargaService;

        public EstacaoRecargasController(IEstacaoRecargaService estacaoRecargaService)
        {
            _estacaoRecargaService = estacaoRecargaService;
        }

        // GET: EstacaoRecargas
        public async Task<IActionResult> Index()
        {
            return View(await _estacaoRecargaService.ObterTodos());
        }

        // GET: EstacaoRecargas/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacaoRecarga = await _estacaoRecargaService.ObterPorId(id);

            if (estacaoRecarga == null)
            {
                return NotFound();
            }

            return View(estacaoRecarga);
        }

        // GET: EstacaoRecargas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstacaoRecargas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] EstacaoRecargaViewModel estacaoRecarga)
        {
            if (ModelState.IsValid)
            {
                await _estacaoRecargaService.Adicionar(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            return View(estacaoRecarga);
        }

        // GET: EstacaoRecargas/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacaoRecarga = await _estacaoRecargaService.ObterPorId(id);
            if (estacaoRecarga == null)
            {
                return NotFound();
            }
            return View(estacaoRecarga);
        }

        // POST: EstacaoRecargas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Tipo,Latitude,Longitude")] EstacaoRecargaViewModel estacaoRecarga)
        {           

            if (ModelState.IsValid)
            {
                try
                {
                    await _estacaoRecargaService.Atualizar(estacaoRecarga);
                }
                catch (DbUpdateConcurrencyException)
                {                    
                    throw;
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(estacaoRecarga);
        }

        // GET: EstacaoRecargas/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacaoRecarga = await _estacaoRecargaService.ObterPorId(id);
            if (estacaoRecarga == null)
            {
                return NotFound();
            }

            return View(estacaoRecarga);
        }

        // POST: EstacaoRecargas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var estacaoRecarga = await _estacaoRecargaService.ObterPorId(id);
            await _estacaoRecargaService.Remover(estacaoRecarga);

            return RedirectToAction(nameof(Index));
        }

        private bool EstacaoRecargaExists(Guid id)
        {
            return _estacaoRecargaService.ObterPorId(id) != null;
        }
    }
}
