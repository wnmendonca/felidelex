using AutoMapper;
using ProjetoFidelidade.Infrastructure;
using ProjetoFidelidade.Model;
using ProjetoFidelidade.Service;
using ProjetoFidelidade.WS;
using ProjetoFidelidade.WS.Models.DTO;
using ProjetoFidelidade.WS.Models.Factory;
using System;
using System.Web.Http;

namespace ProjetoFidelidade.WS.Controllers
{
    [RequireAuth]
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [ActionName("ObterClientePorCPF")]
        public ResultDTO<ClienteDTO> ObterClientePorCPF(string CPF)
        {
            var retorno = _clienteService.GetClienteByCPF(CPF);

            if (retorno == null)
                return new ResultDTO<ClienteDTO>()
                {
                    Result = null,
                    Message = "CPF inexistente na base.",
                    StatusCode = (int)StatusCodeEnum.Error
                };

            return new ResultDTO<ClienteDTO>()
            {
                Result = new ClienteDTO()
                {
                    Nome = retorno.Nome,
                    CPF = retorno.CPF,
                    Email = retorno.Email,
                    DddCelular = retorno.DddCelular,
                    Celular = retorno.Celular,
                    DataCadastro = retorno.DataCadastro
                },
                Message = "",
                StatusCode = (int)StatusCodeEnum.Success
            };
        }

        [HttpPost]
        [ActionName("CriarCliente")]
        public ResultDTO<ClienteDTO> CriarCliente(ClienteDTO entrada)
        {
            // TODO: Terminar esse recurso
            return new ResultDTO<ClienteDTO>()
            {
                Result = new ClienteFactory().Convert(_clienteService.GetCliente(1)),
                Message = "",
                StatusCode = (int)StatusCodeEnum.Success
            };
        }
    }
}
