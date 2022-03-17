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
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<CITY> _city;
        //private readonly DbSet<Country> _country;
        private readonly ICountryRepository _country;

        public CityRepository(AppDbContext categoryDbContext, ICountryRepository countryRepository)
        {
            _categoryDbContext = categoryDbContext;
            _city = _categoryDbContext.Set<CITY>();
            _country = countryRepository;

        }

        public void Remove(CITY city)
        {
            _city.Remove(city);
        }

        public void Update(CITY city)
        {
            _city.Update(city);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(CITY city, CancellationToken cancellationToken)
        {
            await _city.AddAsync(city, cancellationToken);
        }

        public async ValueTask<IList<CITY>> GetAllByCountryCode(string countryCode,CancellationToken cancellation)
        {
            try {
            
                COUNTRY? result =  await _country.GetByCode(countryCode, cancellation);

                if (result != null)
                    return await _city
                                    .AsNoTracking()
                                    .Where(c=>c.ID == result.ID)
                                    .ToListAsync(cancellation);
                else {
                    return new CITY[0];
                }
            }
            catch (Exception) {
                return new CITY[0];
            }
        }

        public async  ValueTask<Domain.CITY?> GetByCity_Country_Code(string cityCode, string countryCode, CancellationToken cancellationToken)
        { 
            try {
                  
                COUNTRY? result =  await _country.GetByCode(countryCode, cancellationToken);

                if (result != null)
                    return await _city
                                    .SingleOrDefaultAsync(x => x.CODE == cityCode && x.ID == result.ID, cancellationToken: cancellationToken);
                else {
                    return new CITY();
                }
            }
            catch (Exception) {
                return new CITY();
            }
            
        }

       
    }
}
