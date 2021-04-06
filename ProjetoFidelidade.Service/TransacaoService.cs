using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Data.Repositories;
using ProjetoFidelidade.Infrastructure.Helpers;
using ProjetoFidelidade.Model;
using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Service
{
    public interface ITransacaoService
    {
        IEnumerable<Transacao> GetTransacao(int clienteEstabelecimentoId);
        void CreateTransacao(Transacao transacao);
        void UpdateTransacao(Transacao transacao);
    }

    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository transacaoRepository;
        private readonly IUnitOfWork unitOfWork;

        public TransacaoService(ITransacaoRepository transacaoRepository, IUnitOfWork unitOfWork)
        {
            this.transacaoRepository = transacaoRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Transacao> GetTransacao(int clienteEstabelecimentoId)
        {
            return transacaoRepository.GetTransacao(clienteEstabelecimentoId);
        }

        public void CreateTransacao(Transacao transacao)
        {
            transacaoRepository.CreateTransacao(transacao);
            SaveTransacao();
        }

        public void UpdateTransacao(Transacao transacao)
        {
            transacaoRepository.Update(transacao);
            SaveTransacao();
        }

        public void SaveTransacao()
        {
            unitOfWork.Commit();
        }
    }
}
