using ProjetoFidelidade.WS.Filters;
using ProjetoFidelidade.WS.Mappings;
using System.Web.Http;

namespace ProjetoFidelidade.WS
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(ExceptionsPolicyConfig.Register);
            GlobalConfiguration.Configuration.Filters.Add(new ValidateModelFilter());
            AutoMapperConfiguration.Configure();

            Bootstrapper.Run();
        }
    }
}
