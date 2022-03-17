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
    public class PostalCodeRepository : IPostalCodeRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<POSTALCODE> _postalCode;

        public PostalCodeRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _postalCode = _categoryDbContext.Set<POSTALCODE>();
        }

        public void Remove(POSTALCODE PostalCode)
        {
            _postalCode.Remove(PostalCode);
        }

        public void Update(POSTALCODE PostalCode)
        {
            _postalCode.Update(PostalCode);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(POSTALCODE PostalCode, CancellationToken cancellationToken)
        {
            await _postalCode.AddAsync(PostalCode, cancellationToken);
        }

      


       
    }
}
