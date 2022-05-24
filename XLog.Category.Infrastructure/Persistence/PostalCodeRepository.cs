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
        private readonly DbSet<COUNTRY> _country;
        private readonly DbSet<PROVINCES> _provinces;
        private readonly DbSet<DISTRICTS> _districts;
        private readonly DbSet<WARDS> _wards;

        public PostalCodeRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _postalCode = _categoryDbContext.Set<POSTALCODE>();
            _country = _categoryDbContext.Set<COUNTRY>();
            _provinces = _categoryDbContext.Set<PROVINCES>();
            _districts = _categoryDbContext.Set<DISTRICTS>();
            _wards = _categoryDbContext.Set<WARDS>();
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
        public async ValueTask<IEnumerable<Domain.POSTALCODE>> GetByCountry_City_District_Ward_Code(string countryCode,string cityCode,string districtCode,string wardCode, CancellationToken cancellationToken)
        {
            return await _categoryDbContext.POSTALCODE
            .Join(_categoryDbContext.WARDS,postalcode => postalcode.WARDID,wards => wards.ID,(postalcode,wards)
            => new {Postalcode = postalcode, Wards = wards})
            .Join(_categoryDbContext.DISTRICTS,PW => PW.Wards.DISTRICTID,districts => districts.ID,(PW,districts)
            => new {PostalcodeWards = PW, Districts = districts})
            .Join(_categoryDbContext.PROVINCES,PWD => PWD.Districts.PROVINCEID, provinces => provinces.ID,(PWD,provinces)
            => new {PostalcodeWardsDistricts = PWD, Provinces = provinces})
            .Join(_categoryDbContext.COUNTRY,PWDP => PWDP.Provinces.COUNTRYID,country => country.ID,(PWDP,country)
            => new {PostalcodeWardsDistrictsProvinces = PWDP,Country = country})
            .Where(result => result.Country.CODE == countryCode)
            .Where(result => result.PostalcodeWardsDistrictsProvinces.Provinces.CODE == cityCode)
            .Where(result => result.PostalcodeWardsDistrictsProvinces.PostalcodeWardsDistricts.Districts.CODE == districtCode)
            .Where(result => result.PostalcodeWardsDistrictsProvinces.PostalcodeWardsDistricts.PostalcodeWards.Wards.CODE == wardCode)
            .Select(x => x.PostalcodeWardsDistrictsProvinces.PostalcodeWardsDistricts.PostalcodeWards.Postalcode)
            .ToListAsync(cancellationToken);
        }
    }
}