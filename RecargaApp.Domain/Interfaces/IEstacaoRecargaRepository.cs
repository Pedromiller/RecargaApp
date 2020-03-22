using RecargaApp.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecargaApp.Domain.Interfaces
{
    public interface IEstacaoRecargaRepository : IRepository<EstacaoRecarga>
    {
        Task<IEnumerable<EstacaoRecarga>> ObterTodos();
        Task<EstacaoRecarga> ObterPorId(Guid id);
        Task<IEnumerable<EstacaoRecarga>> ObterPorTipo(string tipo);

        void Adicionar(EstacaoRecarga estacaoRecarga);
        void Atualizar(EstacaoRecarga estacaoRecarga);
        void Remover(EstacaoRecarga estacaoRecarga);
    }
}
