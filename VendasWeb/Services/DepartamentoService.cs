using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb.Data;
using VendasWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace VendasWeb.Services
{
    public class DepartamentoService
    {
        private readonly VendasWebContext _context;

        public DepartamentoService(VendasWebContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();

        }



    }
}
