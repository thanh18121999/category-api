using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class TransportTypeRepository : ITransportTypeRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<TRANSPORTTYPES> _transportType;


        public TransportTypeRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _transportType = _categoryDbContext.Set<TRANSPORTTYPES>();
        }

        public void Remove(TRANSPORTTYPES transportType)
        {
            _transportType.Remove(transportType);
        }

        public void Update(TRANSPORTTYPES transportType)
        {
            _transportType.Update(transportType);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(TRANSPORTTYPES transportType, CancellationToken cancellationToken)
        {
            await _transportType.AddAsync(transportType, cancellationToken);
        } 


        public async ValueTask<IEnumerable<TRANSPORTTYPES>> GetAll(CancellationToken cancellation)
        {
            return await _transportType
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }   
    }
}
