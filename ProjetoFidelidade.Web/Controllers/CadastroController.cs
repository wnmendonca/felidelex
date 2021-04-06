using ProjetoFidelidade.Infrastructure;
using ProjetoFidelidade.Web.Helpers;
using ProjetoFidelidade.Web.Models;
using ProjetoFidelidade.Web.Models.DTO;
using ProjetoFidelidade.Web.ViewModels;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjetoFidelidade.Web.Controllers
{
    public class CadastroController : Controller
    {
        public readonly ApiIntegration _integration = new ApiIntegration();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(ClienteViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            else
            {
                ClienteDTO objEntrada = new ClienteDTO
                {
                    Nome = model.Nome,
                    CPF = model.CPF,
                    Email = model.Email,
                    DddCelular = model.DddCelular,
                    Celular = model.Celular
                };

                var result = _integration.CriarCliente(objEntrada);

                if (result.StatusCode == (int)StatusCodeEnum.Success)
                {
                    SessionHelper.ClienteLogadoModel = new ClienteModel()
                    {
                        Id = result.Result.Id,
                        PrimeiroNome = result.Result.Nome.Split(' ')[0].ToString()
                    };
                    FormsAuthentication.SetAuthCookie(model.CPF, false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View(model);
                }
            }
        }
    }
}