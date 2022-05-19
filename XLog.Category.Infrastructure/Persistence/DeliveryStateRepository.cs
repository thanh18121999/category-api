using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class DeliveryStateRepository : IDeliveryStateRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<DELIVERYSTATES> _deliveryState;


        public DeliveryStateRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _deliveryState = _categoryDbContext.Set<DELIVERYSTATES>();
        }

        public void Remove(DELIVERYSTATES deliveryState)
        {
            _deliveryState.Remove(deliveryState);
        }

        public void Update(DELIVERYSTATES deliveryState)
        {
            _deliveryState.Update(deliveryState);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(DELIVERYSTATES deliveryState, CancellationToken cancellationToken)
        {
            await _deliveryState.AddAsync(deliveryState, cancellationToken);
        } 


        public async ValueTask<IEnumerable<DELIVERYSTATES>> GetAll(CancellationToken cancellation)
        {
            return await _deliveryState
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }   
    }
}
