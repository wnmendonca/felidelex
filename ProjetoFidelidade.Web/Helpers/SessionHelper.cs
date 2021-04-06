using ProjetoFidelidade.Web.Models;
using System.Web;

namespace ProjetoFidelidade.Web.Helpers
{
    public class SessionHelper
    {
        public static ClienteModel ClienteLogadoModel
        {
            get { return HttpContext.Current.Session["clientelogado"] != null ? (ClienteModel)HttpContext.Current.Session["clientelogado"] : null; }
            set { HttpContext.Current.Session["clientelogado"] = value; }
        }
    }
}