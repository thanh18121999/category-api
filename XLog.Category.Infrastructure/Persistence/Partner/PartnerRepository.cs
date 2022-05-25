using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<PARTNERS> _partners;


        public PartnerRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _partners = _categoryDbContext.Set<PARTNERS>();
        }

        public void Remove(PARTNERS partner)
        {
            _partners.Remove(partner);
        }

        public void Update(PARTNERS partner)
        {
            _partners.Update(partner);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask<PARTNERS?> GetAsync(string id, CancellationToken cancellationToken)
        {
            return await _partners.SingleOrDefaultAsync(x => x.ID == id, cancellationToken: cancellationToken);
        }

        public async ValueTask<IList<PARTNERS>> GetPartnersAsync(int pageSize, CancellationToken cancellationToken)
        {
            

            return await _partners
                                  .AsNoTracking()
                                  .OrderBy(x => x.NAME)
                                  //.Skip((pageIndex - 1) * pageSize)
                                  .Take(pageSize)
                                 //.Include(x => x.Store)
                                 .ToListAsync(cancellationToken);
        }


        public async ValueTask AddAsync(PARTNERS partner, CancellationToken cancellationToken)
        {
            await _partners.AddAsync(partner, cancellationToken);
        }

        public async ValueTask<int> CountAsync(CancellationToken cancellationToken)
        {
            return await _partners.CountAsync(cancellationToken);
        }

        public async ValueTask<IList<PARTNERS>> SearchAsync(string filter,
                                                                   int pageIndex,
                                                                   int pageSize,
                                                                   CancellationToken cancellation)
        {
            return await _partners
                                  .AsNoTracking()
                                  //.Where(x => x.Name.Contains(filter) || x.Code.Contains(filter))
                                  .OrderBy(x => x.NAME)
                                  .Skip((pageIndex - 1) * pageSize)
                                  .Take(pageSize)
                                  //.Include(x => x.Store)
                                 .ToListAsync(cancellation);
        }

       
    }
}