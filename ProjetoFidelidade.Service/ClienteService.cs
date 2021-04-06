using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Data.Repositories;
using ProjetoFidelidade.Infrastructure.Helpers;
using ProjetoFidelidade.Model;
using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Service
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetClientes();
        Cliente GetCliente(int id);
        void CreateCliente(Cliente cliente);
        Cliente GetByCPF(string cpf);
    }

    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IUnitOfWork unitOfWork;

        public ClienteService(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            this.clienteRepository = clienteRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateCliente(Cliente cliente)
        {
            if (!ValidationHelper.ValidaCPF(cliente.CPF))
                throw new ArgumentException("CPF inválido.");

            clienteRepository.Add(cliente);
            this.SaveCliente();
        }

        public Cliente GetCliente(int id)
        {
            return clienteRepository.GetById(id);
        }

        public Cliente GetByCPF(string cpf)
        {
            if (!ValidationHelper.ValidaCPF(cpf))
                return null;

            return clienteRepository.GetByCPF(cpf);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return clienteRepository.GetAll();
        }

        public void SaveCliente()
        {
            unitOfWork.Commit();
        }
    }
}
