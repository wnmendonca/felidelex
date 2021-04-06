using ProjetoFidelidade.Infrastructure;
using ProjetoFidelidade.Web.Helpers;
using ProjetoFidelidade.Web.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjetoFidelidade.Web.Controllers
{
    public class LoginController : Controller
    {
        public readonly ApiIntegration _integration = new ApiIntegration();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Login", "Digite o CPF para logar no Felidelex.");
                return View(model);
            }
            else
            {
                var resultIntegracao = _integration.ObterClientePorCPF(model.CPF.ToString());

                if (resultIntegracao.StatusCode == (int)StatusCodeEnum.Success)
                {
                    SessionHelper.ClienteLogadoModel = new ClienteModel()
                    {
                        Id = resultIntegracao.Result.Id,
                        PrimeiroNome = resultIntegracao.Result.Nome.Split(' ')[0].ToString()
                    };
                    FormsAuthentication.SetAuthCookie(model.CPF, false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Login", "Não foi possível realizar o login. Tente novamente mais tarde.");
                    return View(model);
                }
            }
        }

        public ActionResult RedirecToLogin()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}