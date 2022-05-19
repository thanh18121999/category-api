using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class MerchandiseTypeRepository : IMerchandiseTypeRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<MERCHANDISETYPE> _merchandisetype;


        public MerchandiseTypeRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _merchandisetype = _categoryDbContext.Set<MERCHANDISETYPE>();
        }

        public void Remove(MERCHANDISETYPE merchandisetype)
        {
            _merchandisetype.Remove(merchandisetype);
        }

        public void Update(MERCHANDISETYPE merchandisetype)
        {
            _merchandisetype.Update(merchandisetype);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(MERCHANDISETYPE merchandisetype, CancellationToken cancellationToken)
        {
            await _merchandisetype.AddAsync(merchandisetype, cancellationToken);
        } 

        public async ValueTask<MERCHANDISETYPE?> GetMerchandiseType(string merchandiseTypeID, CancellationToken cancellationToken)
        {
            return await _merchandisetype
                                .AsNoTracking()
                                .SingleOrDefaultAsync(x => x.ID == merchandiseTypeID, cancellationToken: cancellationToken);
        }
        public async ValueTask<IEnumerable<MERCHANDISETYPE>> GetAll(CancellationToken cancellation)
        {
            return await _merchandisetype
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }
    }
}
