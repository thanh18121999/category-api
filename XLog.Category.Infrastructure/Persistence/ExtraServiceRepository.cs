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
    public class ExtraServiceRepository : IExtraServiceRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<EXTRASERVICE> _extraService;


        public ExtraServiceRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _extraService = _categoryDbContext.Set<EXTRASERVICE>();
        }

        public void Remove(EXTRASERVICE extraservice)
        {
            _extraService.Remove(extraservice);
        }

        public void Update(EXTRASERVICE extraservice)
        {
            _extraService.Update(extraservice);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(EXTRASERVICE extraservice, CancellationToken cancellationToken)
        {
            await _extraService.AddAsync(extraservice, cancellationToken);
        } 

        public async ValueTask<EXTRASERVICE?> GetExtraService(string extraServiceID, CancellationToken cancellationToken)
        {
            return await _extraService
                                .AsNoTracking()
                                .SingleOrDefaultAsync(x => x.ID == extraServiceID, cancellationToken: cancellationToken);
        }
        public async ValueTask<IEnumerable<EXTRASERVICE?>> GetAll(CancellationToken cancellationToken)
        {
            return await _extraService
                                .AsNoTracking()
                                .ToListAsync(cancellationToken);
        }
    }
}
