using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RecargaApp.Application.ViewModels;
using RecargaApp.Domain.Aggregates;
using RecargaApp.Domain.Interfaces;

namespace RecargaApp.Application.Services
{
    public class EstacaoRecargaService : IEstacaoRecargaService
    {
        private readonly IEstacaoRecargaRepository _estacaoRecargaRepository;
        private readonly IMapper _mapper;

        public EstacaoRecargaService(IEstacaoRecargaRepository estacaoRecargaRepository, IMapper mapper)
        {
            _estacaoRecargaRepository = estacaoRecargaRepository;
            _mapper = mapper;            
        }
        public async Task Adicionar(EstacaoRecargaViewModel estacaoRecargaViewModel)
        {
            _estacaoRecargaRepository
                .Adicionar(_mapper.Map<EstacaoRecarga>(estacaoRecargaViewModel));

            await _estacaoRecargaRepository.UnitOfWork.Commit();
        }

        public async Task Atualizar(EstacaoRecargaViewModel estacaoRecargaViewModel)
        {
            _estacaoRecargaRepository
                .Atualizar(_mapper.Map<EstacaoRecarga>(estacaoRecargaViewModel));

            await _estacaoRecargaRepository.UnitOfWork.Commit();
        }

        public async Task<EstacaoRecargaViewModel> ObterPorId(Guid id)
        {
            return _mapper
                .Map<EstacaoRecargaViewModel>(await _estacaoRecargaRepository.ObterPorId(id));
        }

        public async Task<IEnumerable<EstacaoRecargaViewModel>> ObterPorTipo(string tipo)
        {
            return _mapper
                .Map<IEnumerable<EstacaoRecargaViewModel>>( await _estacaoRecargaRepository
                .ObterPorTipo(_mapper.Map<string>(tipo)));
        }

        public async Task<IEnumerable<EstacaoRecargaViewModel>> ObterTodos()
        {
            return _mapper
                .Map<IEnumerable<EstacaoRecargaViewModel>>(await _estacaoRecargaRepository
                .ObterTodos());
        }

        public async Task Remover(EstacaoRecargaViewModel estacaoRecarga)
        {            
            _estacaoRecargaRepository.Remover(_mapper.Map<EstacaoRecarga>(estacaoRecarga));
            await _estacaoRecargaRepository.UnitOfWork.Commit();
        }
    }
}
