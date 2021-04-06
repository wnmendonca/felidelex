using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFidelidade.Admin.Models.DTO
{
    public class ResultDTO<T>
    {
        public T Result;
        public int StatusCode;
        public string Message;
    }
}