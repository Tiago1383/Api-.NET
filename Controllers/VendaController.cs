using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Teste.Context;
using Teste.Models;

namespace Teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly BancoDeDadosContext _context;

        public VendaController(BancoDeDadosContext context)
        {
            _context = context;
        }

        [HttpPost("Registra Venda")]
        public IActionResult Create(Vendas vendas)
        {
            _context.Add(vendas);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = vendas.Id }, vendas);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendas = _context.Vendas.Find(id);

            if (vendas == null)
                return NotFound();

            return Ok(vendas);
        }

    }
}