using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Linq;
using System.Configuration;
using System.Net.Http;
using System.Net;

namespace ProjetoFidelidade.WS
{
    public class RequireAuth : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var header = actionContext.Request.Headers.SingleOrDefault(x => x.Key == "Auth-API-Key");
            var valid = header.Value != null && header.Value.First() == ConfigurationManager.AppSettings["Auth-API-Key"].ToString();

            if (!valid)
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
    }
}