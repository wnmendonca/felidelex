using ProjetoFidelidade.Web.Filters;
using ProjetoFidelidade.Web.Helpers;
using System.Web.Mvc;

namespace ProjetoFidelidade.Web.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuthorize]
        public ActionResult Index()
        {
            TempData["nome"] = SessionHelper.ClienteLogadoModel.PrimeiroNome;
            return View();
        }
    }
}