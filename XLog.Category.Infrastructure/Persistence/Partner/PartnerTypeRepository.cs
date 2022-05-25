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
    public class PartnerTypeRepository : IPartnerTypeRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<PARTNERTYPE> _partnertype;

        public PartnerTypeRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _partnertype = _categoryDbContext.Set<PARTNERTYPE>();
        }
        public void Remove(PARTNERTYPE partnertype)
        {
            _partnertype.Remove(partnertype);
        }
        public void Update(PARTNERTYPE partnertype)
        {
            _partnertype.Update(partnertype);
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }
        public async ValueTask AddAsync(PARTNERTYPE partnertype, CancellationToken cancellationToken)
        {
            await _partnertype.AddAsync(partnertype, cancellationToken);
        } 
        public async ValueTask<PARTNERTYPE?> GetPartnerType(string partnerTypeID, CancellationToken cancellationToken)
        {
            return await _partnertype
                                .AsNoTracking()
                                .SingleOrDefaultAsync(x => x.ID == partnerTypeID, cancellationToken: cancellationToken);
        }        
    }
}
