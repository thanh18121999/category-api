using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IExtraServiceRepository
    {
        //void SeedDatabase();
        void Remove (Domain.EXTRASERVICE extraservice);
        void Update (Domain.EXTRASERVICE extraservice);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.EXTRASERVICE extraservice, CancellationToken cancellationToken);
        ValueTask<Domain.EXTRASERVICE?> GetExtraService (string extraServiceID, CancellationToken cancellationToken);
    }
}
