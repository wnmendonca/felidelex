using System;

namespace ProjetoFidelidade.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        Entities Init();
    }
}