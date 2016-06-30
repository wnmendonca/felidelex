using ProjetoFidelidade.Model;
using ProjetoFidelidade.Service;
using ProjetoFidelidade.WS.App_Start;
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
        [ActionName("ObterCliente")]
        public Cliente ObterCliente(string z)
        {
            return _clienteService.GetClienteByCPF(z);
        }
    }
}
