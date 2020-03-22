using Microsoft.EntityFrameworkCore;
using RecargaApp.Domain.Aggregates;
using RecargaApp.Domain.Interfaces;
using RecargaApp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecargaApp.Infra.Data.Repositories
{
    public class EstacaoRecargaRepository : IEstacaoRecargaRepository
    {
        private readonly RecargaAppContext _context;
        public EstacaoRecargaRepository(RecargaAppContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(EstacaoRecarga estacaoRecarga)
        {
            _context.EstacaoRecarga.AddAsync(estacaoRecarga);
        }

        public void Atualizar(EstacaoRecarga estacaoRecarga)
        {
            _context.EstacaoRecarga.Update(estacaoRecarga); 
        }
                
        public async Task<EstacaoRecarga> ObterPorId(Guid Id)
        {
            return await _context.EstacaoRecarga
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<IEnumerable<EstacaoRecarga>> ObterTodos()
        {
            return await _context.EstacaoRecarga
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<EstacaoRecarga>> ObterPorTipo(string tipo)
        {
            return await _context.EstacaoRecarga
                .AsNoTracking()
                .Where(x => x.Tipo == tipo)
                .ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Remover(EstacaoRecarga estacaoRecarga)
        {
            _context.EstacaoRecarga.Remove(estacaoRecarga);
        }
    }
}
