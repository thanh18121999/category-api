using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IPartnerRepository
    {
        //void SeedDatabase();
        void Remove(Domain.PARTNERS partner);

        void Update(Domain.PARTNERS partner);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask<Domain.PARTNERS?> GetAsync(string id, CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.PARTNERS partner, CancellationToken cancellationToken);

        ValueTask<int> CountAsync(CancellationToken cancellationToken);

        ValueTask<IList<Domain.PARTNERS>> GetPartnersAsync(int pageSize, CancellationToken cancellationToken);

        ValueTask<IList<Domain.PARTNERS>> SearchAsync(string filter, int pageIndex, int pageSize, CancellationToken cancellationToken);

    }
}