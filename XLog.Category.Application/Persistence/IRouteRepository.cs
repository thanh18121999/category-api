using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IRouteRepository
    {
        //void SeedDatabase();
        void Remove(Domain.ROUTES route);
        void Update(Domain.ROUTES route);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.ROUTES route, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.ROUTES>> GetAll(CancellationToken cancellation);
    }
}
