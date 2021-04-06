using ProjetoFidelidade.Web.Controllers;
using System.Web.Mvc;
using System.Web;
using ProjetoFidelidade.Web.Helpers;

namespace ProjetoFidelidade.Web.Filters
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var result = new ViewResult();
            filterContext.Result = (new LoginController()).RedirecToLogin();
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var rd = httpContext.Request.RequestContext.RouteData;
            var currentAction = rd.GetRequiredString("action");
            var currentController = rd.GetRequiredString("controller");
            var target = (currentController + "/" + currentAction).ToLower();
            if (!httpContext.User.Identity.IsAuthenticated || SessionHelper.ClienteLogadoModel == null)
                return false;

            return true;
        }
    }
}