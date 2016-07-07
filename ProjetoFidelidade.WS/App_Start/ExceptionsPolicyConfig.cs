using ProjetoFidelidade.WS.Filters;
using System.Web.Http;

namespace ProjetoFidelidade.WS
{
    public class ExceptionsPolicyConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Never;

            GlobalConfiguration.Configuration.Filters.Add(new RegularToHttpExceptionFilter());
        }
    }
}