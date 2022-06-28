using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface ITransportTypeRepository
    {
        //void SeedDatabase();
        void Remove(Domain.TRANSPORTTYPES  transportType);
        void Update(Domain.TRANSPORTTYPES  transportType);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.TRANSPORTTYPES  transportType, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.TRANSPORTTYPES >> GetAll(CancellationToken cancellation);
    }
}
