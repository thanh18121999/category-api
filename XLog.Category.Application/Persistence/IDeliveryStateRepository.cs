using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IDeliveryStateRepository
    {
        //void SeedDatabase();
        void Remove(Domain.DELIVERYSTATES deliveryState);
        void Update(Domain.DELIVERYSTATES deliveryState);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.DELIVERYSTATES deliveryState, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.DELIVERYSTATES>> GetAll(CancellationToken cancellation);

    }
}
