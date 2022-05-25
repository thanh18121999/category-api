using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IDeliveryMethodRepository
    {
        //void SeedDatabase();
        void Remove(Domain.DELIVERYMETHODS deliveryMethod);
        void Update(Domain.DELIVERYMETHODS deliveryMethod);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.DELIVERYMETHODS deliveryMethod, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.DELIVERYMETHODS>> GetAll(CancellationToken cancellation);
    }
}
