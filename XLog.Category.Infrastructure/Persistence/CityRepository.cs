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
        private readonly DbSet<PROVINCES> _city;
        private readonly DbSet<COUNTRY> _country;
        //private readonly DbSet<Country> _country;
        private readonly ICountryRepository _countries;

        public CityRepository(AppDbContext categoryDbContext, ICountryRepository countryRepository)
        {
            _categoryDbContext = categoryDbContext;
            _city = _categoryDbContext.Set<PROVINCES>();
            _country = _categoryDbContext.Set<COUNTRY>();
            _countries = countryRepository;

        }

        public void Remove(PROVINCES city)
        {
            _city.Remove(city);
        }

        public void Update(PROVINCES city)
        {
            _city.Update(city);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(PROVINCES city, CancellationToken cancellationToken)
        {
            await _city.AddAsync(city, cancellationToken);
        }

        public async ValueTask<IEnumerable<PROVINCES>> GetAllByCountryCode(string countryCode,CancellationToken cancellation)
        {
            return await _categoryDbContext.PROVINCES.Join(_categoryDbContext.COUNTRY,provinces => provinces.COUNTRYID,country => country.ID,  (provinces,country) =>
                                                new {Provinces = provinces,Country = country })
                                                .Where(result => result.Country.CODE == countryCode)
                                                .Select(result => result.Provinces)
                                                .ToListAsync(cancellation); 
        }

        public async  ValueTask<IEnumerable<Domain.PROVINCES?>> GetByCity_Country_Code(string cityCode, string countryCode, CancellationToken cancellationToken)
        {
            return await _categoryDbContext.PROVINCES.Join(_categoryDbContext.COUNTRY,provinces => provinces.COUNTRYID,country => country.ID,  (provinces,country) =>
                                                new {Provinces = provinces,Country = country })
                                                .Where(result => result.Country.CODE == countryCode)
                                                .Where(result => result.Provinces.CODE == cityCode)
                                                .Select(result => result.Provinces)
                                                .ToListAsync(cancellationToken); 
        }
    }
}
