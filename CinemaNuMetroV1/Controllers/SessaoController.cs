﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaNuMetroV1.Data;
using CinemaNuMetroV1.Models;

namespace CinemaNuMetroV1.Controllers
{
    public class SessaoController : Controller
    {
        private readonly CinemaNuMetroV1Context _context;

        public SessaoController(CinemaNuMetroV1Context context)
        {
            _context = context;
        }

        // GET: Sessao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sessao.ToListAsync());
        }

        // GET: Sessao/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessao == null)
            {
                return NotFound();
            }

            return View(sessao);
        }

        // GET: Sessao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sessao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,tipoSessao,data,horario,acessorios,sala")] Sessao sessao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sessao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sessao);
        }

        // GET: Sessao/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessao.FindAsync(id);
            if (sessao == null)
            {
                return NotFound();
            }
            return View(sessao);
        }

        // POST: Sessao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,tipoSessao,data,horario,acessorios,sala")] Sessao sessao)
        {
            if (id != sessao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessaoExists(sessao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sessao);
        }

        // GET: Sessao/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessao == null)
            {
                return NotFound();
            }

            return View(sessao);
        }

        // POST: Sessao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var sessao = await _context.Sessao.FindAsync(id);
            if (sessao != null)
            {
                _context.Sessao.Remove(sessao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessaoExists(long id)
        {
            return _context.Sessao.Any(e => e.Id == id);
        }
    }
}
