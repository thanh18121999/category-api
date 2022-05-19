using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IPartnerTypeRepository
    {
        //void SeedDatabase();
        void Remove(Domain.PARTNERTYPE partnertype);
        void Update(Domain.PARTNERTYPE partnertype);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.PARTNERTYPE partnertype, CancellationToken cancellationToken);
        ValueTask<Domain.PARTNERTYPE?> GetPartnerType(string partnerTypeID, CancellationToken cancellationToken);
    }
}