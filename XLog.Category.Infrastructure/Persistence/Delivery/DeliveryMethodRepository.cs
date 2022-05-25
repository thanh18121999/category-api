using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class DeliveryMethodRepository : IDeliveryMethodRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<DELIVERYMETHODS> _deliveryMethod;


        public DeliveryMethodRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _deliveryMethod = _categoryDbContext.Set<DELIVERYMETHODS>();
        }

        public void Remove(DELIVERYMETHODS deliveryMethod)
        {
            _deliveryMethod.Remove(deliveryMethod);
        }

        public void Update(DELIVERYMETHODS deliveryMethod)
        {
            _deliveryMethod.Update(deliveryMethod);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(DELIVERYMETHODS deliveryMethod, CancellationToken cancellationToken)
        {
            await _deliveryMethod.AddAsync(deliveryMethod, cancellationToken);
        } 


        public async ValueTask<IEnumerable<DELIVERYMETHODS>> GetAll(CancellationToken cancellation)
        {
            return await _deliveryMethod
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }   
    }
}
