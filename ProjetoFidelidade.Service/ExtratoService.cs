using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Data.Repositories;
using ProjetoFidelidade.Infrastructure.Helpers;
using ProjetoFidelidade.Model;
using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Service
{
    public interface IExtratoService
    {
        IEnumerable<Extrato> GetExtrato(int clienteEstabelecimentoId);
    }

    public class ExtratoService : IExtratoService
    {
        private readonly IExtratoRepository extratoRepository;
        private readonly IUnitOfWork unitOfWork;

        public ExtratoService(IExtratoRepository extratoRepository, IUnitOfWork unitOfWork)
        {
            this.extratoRepository = extratoRepository;
            this.unitOfWork = unitOfWork;
        }


        public IEnumerable<Extrato> GetExtrato(int clienteEstabelecimentoId)
        {
            return extratoRepository.GetExtrato(clienteEstabelecimentoId);
        }
    }
}
