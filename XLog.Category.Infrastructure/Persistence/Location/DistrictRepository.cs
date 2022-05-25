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
    public class DistrictRepository : IDistrictRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<DISTRICTS> _district;
        private readonly DbSet<COUNTRY> _country;
        private readonly DbSet<PROVINCES> _provinces;
        private readonly DbSet<WARDS> _wards;
        private readonly ICityRepository _city;
        private readonly ICountryRepository _countries;
        // private readonly IWardRepository _ward;

        public DistrictRepository(AppDbContext categoryDbContext, ICityRepository cityRepository,ICountryRepository countryRepository)
        {
            _categoryDbContext = categoryDbContext;
            _district = _categoryDbContext.Set<DISTRICTS>();
            _provinces = _categoryDbContext.Set<PROVINCES>();
            _country = _categoryDbContext.Set<COUNTRY>();
            _wards = _categoryDbContext.Set<WARDS>();
            _city = cityRepository;
            _countries = countryRepository;
            // _ward = wardRepository;

        }

        public void Remove(DISTRICTS district)
        {
            _district.Remove(district);
        }

        public void Update(DISTRICTS district)
        {
            _district.Update(district);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(DISTRICTS district, CancellationToken cancellationToken)
        {
            await _district.AddAsync(district, cancellationToken);
        }

        public async ValueTask<IEnumerable<Domain.DISTRICTS?>> GetByDistrict_City_Country_Code(string districtCode,string cityCode, string countryCode,CancellationToken cancellationToken)
        {
                    return await _categoryDbContext.DISTRICTS.Join(_categoryDbContext.PROVINCES,districts => districts.PROVINCEID,provinces => provinces.ID,  (districts,provinces) =>
                                                new {Districts = districts,Provinces = provinces })
                                                .Join(_categoryDbContext.COUNTRY, DP => DP.Provinces.COUNTRYID, country => country.ID,(DP,country) 
                                                => new { DistrictsProvinces = DP, Country = country})
                                                .Where(result => result.DistrictsProvinces.Districts.CODE == districtCode)
                                                .Where(result => result.DistrictsProvinces.Provinces.CODE == cityCode)
                                                .Where(result => result.Country.CODE == countryCode)
                                                .Select(x => x.DistrictsProvinces.Districts)
                                                .ToListAsync(cancellationToken);

        }
        public async ValueTask<IEnumerable<Domain.DISTRICTS?>> GetAllByCity_CountryCode(string cityCode, string countryCode,CancellationToken cancellation)
        {
            return await _categoryDbContext.DISTRICTS.Join(_categoryDbContext.PROVINCES,districts => districts.PROVINCEID,provinces => provinces.ID,  (districts,provinces) =>
                                                new {Districts = districts,Provinces = provinces })
                                                .Join(_categoryDbContext.COUNTRY, DP => DP.Provinces.COUNTRYID, country => country.ID,(DP,country) 
                                                => new { DistrictsProvinces = DP, Country = country})
                                                .Where(result => result.DistrictsProvinces.Provinces.CODE == cityCode)
                                                .Where(result => result.Country.CODE == countryCode)
                                                .Select(x => x.DistrictsProvinces.Districts)
                                                .ToListAsync(cancellation);
        }

       
    }
}
