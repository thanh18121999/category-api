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
        void Remove(Domain.PARTNER partner);

        void Update(Domain.PARTNER partner);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask<Domain.PARTNER?> GetAsync(string id, CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.PARTNER partner, CancellationToken cancellationToken);

        ValueTask<int> CountAsync(CancellationToken cancellationToken);

        ValueTask<IList<Domain.PARTNER>> GetPartnersAsync(int pageSize, CancellationToken cancellationToken);

        ValueTask<IList<Domain.PARTNER>> SearchAsync(string filter, int pageIndex, int pageSize, CancellationToken cancellationToken);

    }
}
