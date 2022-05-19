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
    public class WardRepository : IWardRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<WARDS> _wards;
        private readonly DbSet<COUNTRY> _country;
        private readonly DbSet<PROVINCES> _provinces;
        private readonly DbSet<DISTRICTS> _districts;
        private readonly IDistrictRepository _district;
        private readonly ICountryRepository _countries;
        private readonly ICityRepository _city;
        public WardRepository(AppDbContext categoryDbContext, IDistrictRepository districtRepository)
        {
            _categoryDbContext = categoryDbContext;
            _wards = _categoryDbContext.Set<WARDS>();
            _district = districtRepository;

        }
        public void Remove(WARDS Wards)
        {
            _wards.Remove(Wards);
        }
        public void Update(WARDS Wards)
        {
            _wards.Update(Wards);
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }
        public async ValueTask AddAsync(WARDS Wards, CancellationToken cancellationToken)
        {
            await _wards.AddAsync(Wards, cancellationToken);
        }

        public async ValueTask<IEnumerable<Domain.WARDS?>> GetByWard_District_City_Country_Code(string wardCode,string districtCode,string cityCode, string countryCode,CancellationToken cancellationToken)
        {
            return await _categoryDbContext.WARDS.Join(
               _categoryDbContext.DISTRICTS,wards => wards.DISTRICTID,districts => districts.ID,(wards,districts)
               => new {Wards = wards, Districts = districts})
               .Join(_categoryDbContext.PROVINCES,WD => WD.Districts.PROVINCEID,provinces => provinces.ID,(WD,provinces)
               => new {WardsDistricts = WD,Provinces = provinces})
               .Join(_categoryDbContext.COUNTRY,WDP => WDP.Provinces.COUNTRYID,country => country.ID,(WDP,country)
               => new {WardsDistrictsProvinces = WDP,Country = country})
               .Where(result => result.WardsDistrictsProvinces.WardsDistricts.Wards.CODE == wardCode)
               .Where(result => result.WardsDistrictsProvinces.WardsDistricts.Districts.CODE == districtCode)
               .Where(result => result.WardsDistrictsProvinces.Provinces.CODE == cityCode)
               .Where(result => result.Country.CODE == countryCode)
               .Select(x=>x.WardsDistrictsProvinces.WardsDistricts.Wards).ToListAsync(cancellationToken);
        }
        public async ValueTask<IEnumerable<Domain.WARDS?>> GetAllByDistrict_City_CountryCode(string districtCode,string cityCode, string countryCode,CancellationToken cancellationToken)
        {
            return await _categoryDbContext.WARDS.Join(
               _categoryDbContext.DISTRICTS,wards => wards.DISTRICTID,districts => districts.ID,(wards,districts)
               => new {Wards = wards, Districts = districts})
               .Join(_categoryDbContext.PROVINCES,WD => WD.Districts.PROVINCEID,provinces => provinces.ID,(WD,provinces)
               => new {WardsDistricts = WD,Provinces = provinces})
               .Join(_categoryDbContext.COUNTRY,WDP => WDP.Provinces.COUNTRYID,country => country.ID,(WDP,country)
               => new {WardsDistrictsProvinces = WDP,Country = country})
               .Where(result => result.WardsDistrictsProvinces.WardsDistricts.Districts.CODE == districtCode)
               .Where(result => result.WardsDistrictsProvinces.Provinces.CODE == cityCode)
               .Where(result => result.Country.CODE == countryCode)
               .Select(x=>x.WardsDistrictsProvinces.WardsDistricts.Wards).ToListAsync(cancellationToken);
        }
    }
}