using RecargaApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecargaApp.Application.Services
{
    public interface IEstacaoRecargaService
    {
        Task<IEnumerable<EstacaoRecargaViewModel>> ObterTodos();
        Task<EstacaoRecargaViewModel> ObterPorId(Guid Id);
        Task<IEnumerable<EstacaoRecargaViewModel>> ObterPorTipo(string Tipo);

        Task Adicionar(EstacaoRecargaViewModel estacaoRecarga);

        Task Atualizar(EstacaoRecargaViewModel estacaoRecarga);
        Task Remover(EstacaoRecargaViewModel estacaoRecarga);

    }
}
