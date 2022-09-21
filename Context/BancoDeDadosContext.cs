using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Context
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options) : base(options)
        {

        }

        public DbSet<Vendas> Vendas { get; set;}

        internal void CreatedAtAction(string v, object value, Vendas vendas)
        {
            throw new NotImplementedException();
        }
    }
}