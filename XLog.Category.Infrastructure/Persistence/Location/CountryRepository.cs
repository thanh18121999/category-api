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
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<COUNTRY> _country;


        public CountryRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _country = _categoryDbContext.Set<COUNTRY>();
        }

        public void Remove(COUNTRY country)
        {
            _country.Remove(country);
        }

        public void Update(COUNTRY country)
        {
            _country.Update(country);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(COUNTRY country, CancellationToken cancellationToken)
        {
            await _country.AddAsync(country, cancellationToken);
        } 

        public async ValueTask<COUNTRY?> GetById(int countryId, CancellationToken cancellationToken)
        {
            return await _country
                                .AsNoTracking()
                                .SingleOrDefaultAsync(x => x.ID == countryId, cancellationToken: cancellationToken);
        }   

        public async ValueTask<COUNTRY?> GetByCode(string countryCode, CancellationToken cancellationToken)
        {
            return await _country
                                .AsNoTracking()
                                .SingleOrDefaultAsync(x => x.CODE == countryCode, cancellationToken: cancellationToken);
        }   

        public async ValueTask<IEnumerable<COUNTRY>> GetAll(CancellationToken cancellation)
        {
            return await _country
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }

       
    }
}
