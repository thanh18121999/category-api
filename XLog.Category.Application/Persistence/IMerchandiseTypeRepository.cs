using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IMerchandiseTypeRepository
    {
        //void SeedDatabase();
        void Remove(Domain.MERCHANDISETYPE merchandisetype);
        void Update(Domain.MERCHANDISETYPE merchandisetype);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.MERCHANDISETYPE merchandisetype, CancellationToken cancellationToken);
        ValueTask<Domain.MERCHANDISETYPE?> GetMerchandiseType(string merchandisesTypeID, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.MERCHANDISETYPE>> GetAll(CancellationToken cancellation);
    }
}