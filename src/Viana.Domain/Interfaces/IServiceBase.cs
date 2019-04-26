using System;

namespace Viana.Domain.Interfaces
{
    public interface IServiceBase
    {
        void StartService();
        TEntity GetService<TEntity>(Func<in T,  out  TEntity>);
    }
}
