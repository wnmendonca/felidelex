using Newtonsoft.Json;
using ProjetoFidelidade.Admin.Models.DTO;
using ProjetoFidelidade.Infrastructure;
using ProjetoFidelidade.Infrastructure.Helpers;
using RestSharp;
using System;
using System.Configuration;
using System.Text;

namespace ProjetoFidelidade.Admin.Helpers
{
    public class ApiIntegration
    {
        private readonly string _baseUrl;

        public ApiIntegration()
        {
            _baseUrl = ConfigurationManager.AppSettings["ApiUrl"];
        }
    }
}