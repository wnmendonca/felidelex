using ProjetoFidelidade.Model;
using System.Collections.Generic;
using System;
using ProjetoFidelidade.Data.Repositories;
using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Infrastructure.Helpers;

namespace ProjetoFidelidade.Service
{
    public interface IEstabelecimentoService
    {
        IEnumerable<Estabelecimento> GetEstabelecimento();
        Estabelecimento GetEstabelecimento(int id);
        void CreateEstabelecimento(Estabelecimento estabelecimento);
        Estabelecimento GetByCNPJ(string cnpj);
    }

    public class EstabelecimentoService : IEstabelecimentoService
    {
        private readonly IEstabelecimentoRepository estabelecimentoRepository;
        private readonly IUnitOfWork unitOfWork;

        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository, IUnitOfWork unitOfWork)
        {
            this.estabelecimentoRepository = estabelecimentoRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateEstabelecimento(Estabelecimento estabelecimento)
        {
            if (!ValidationHelper.ValidaCNPJ(estabelecimento.CNPJ))
                throw new ArgumentException("CNPJ inválido.");

            estabelecimentoRepository.Add(estabelecimento);
            this.SaveEstabelecimento();
        }

        public Estabelecimento GetByCNPJ(string cnpj)
        {
            if (!ValidationHelper.ValidaCNPJ(cnpj))
                return null;

            return estabelecimentoRepository.GetByCNPJ(cnpj);
        }

        public IEnumerable<Estabelecimento> GetEstabelecimento()
        {
            return estabelecimentoRepository.GetAll();
        }

        public Estabelecimento GetEstabelecimento(int id)
        {
            return estabelecimentoRepository.GetById(id);
        }

        public void SaveEstabelecimento()
        {
            unitOfWork.Commit();
        }
    }
}
