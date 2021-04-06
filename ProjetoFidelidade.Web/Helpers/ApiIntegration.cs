using Newtonsoft.Json;
using ProjetoFidelidade.Infrastructure;
using ProjetoFidelidade.Infrastructure.Helpers;
using ProjetoFidelidade.Web.Models.DTO;
using RestSharp;
using System;
using System.Configuration;
using System.Text;

namespace ProjetoFidelidade.Web.Helpers
{
    public class ApiIntegration
    {
        private readonly string _baseUrl;

        public ApiIntegration()
        {
            _baseUrl = ConfigurationManager.AppSettings["ApiUrl"];
        }

        public ResultDTO<ClienteDTO> ObterClientePorCPF(string CPF)
        {
            try
            {
                const string urlServico = "api/Cliente/ObterClientePorCPF";

                var uriQuery = new StringBuilder();
                uriQuery.Append("?CPF=" + CPF);

                IRestResponse result = RestHelper.Get(_baseUrl, urlServico + uriQuery);

                return JsonConvert.DeserializeObject<ResultDTO<ClienteDTO>>(result.Content);
            }
            catch (Exception ex)
            {
                return new ResultDTO<ClienteDTO>()
                {
                    Message = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString(),
                    StatusCode = (int)StatusCodeEnum.Error,
                    Result = null
                };
            }
        }

        public ResultDTO<ClienteDTO> CriarCliente(ClienteDTO entrada)
        {
            try
            {
                const string urlServico = "api/Cliente/CriarCliente";

                IRestResponse result = RestHelper.Post(_baseUrl, urlServico, entrada);

                return JsonConvert.DeserializeObject<ResultDTO<ClienteDTO>>(result.Content);
            }
            catch (Exception ex)
            {
                return new ResultDTO<ClienteDTO>()
                {
                    Message = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString(),
                    StatusCode = (int)StatusCodeEnum.Error,
                    Result = null
                };
            }
        }
    }
}