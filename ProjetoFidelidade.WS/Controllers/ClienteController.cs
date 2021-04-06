using ProjetoFidelidade.Infrastructure;
using ProjetoFidelidade.Model;
using ProjetoFidelidade.Service;
using ProjetoFidelidade.WS.Models.DTO;
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
            var retorno = _clienteService.GetByCPF(CPF);

            if (retorno == null)
                return new ResultDTO<ClienteDTO>()
                {
                    Result = null,
                    Message = "CPF inválido e/ou não cadastrado.",
                    StatusCode = (int)StatusCodeEnum.Error
                };

            return new ResultDTO<ClienteDTO>()
            {
                Result = new ClienteDTO()
                {
                    Id = retorno.Id,
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
            // verifica se ja existe cpf cadastrado
            var retornoCadastrado = _clienteService.GetByCPF(entrada.CPF);
            if (retornoCadastrado != null)
            {
                return new ResultDTO<ClienteDTO>()
                {
                    Result = null,
                    Message = "CPF já está cadastrado.",
                    StatusCode = (int)StatusCodeEnum.Error
                };
            }

            try
            {
                _clienteService.CreateCliente(new Cliente(entrada.Nome, entrada.CPF, entrada.Email, entrada.DddCelular, entrada.Celular, DateTime.Now));
            }
            catch (Exception e)
            {
                return new ResultDTO<ClienteDTO>()
                {
                    Result = null,
                    Message = e.Message,
                    StatusCode = (int)StatusCodeEnum.Error
                };
            }
            

            var clienteCadastrado = _clienteService.GetByCPF(entrada.CPF);

            var retorno = new ClienteDTO
            {
                Id = clienteCadastrado.Id,
                Nome = clienteCadastrado.Nome,
                CPF = clienteCadastrado.CPF,
                Email = clienteCadastrado.Email,
                DddCelular = clienteCadastrado.DddCelular,
                Celular = clienteCadastrado.Celular,
                DataCadastro = clienteCadastrado.DataCadastro
            };

            return new ResultDTO<ClienteDTO>()
            {
                Result = retorno,
                Message = "Cadastro realizado com sucesso.",
                StatusCode = (int)StatusCodeEnum.Success
            };
        }
    }
}
