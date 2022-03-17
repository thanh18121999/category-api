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
        private readonly DbSet<DISTRICT> _district;
        private readonly ICityRepository _city;

        public DistrictRepository(AppDbContext categoryDbContext, ICityRepository cityRepository)
        {
            _categoryDbContext = categoryDbContext;
            _district = _categoryDbContext.Set<DISTRICT>();
            _city = cityRepository;

        }

        public void Remove(DISTRICT district)
        {
            _district.Remove(district);
        }

        public void Update(DISTRICT district)
        {
            _district.Update(district);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(DISTRICT district, CancellationToken cancellationToken)
        {
            await _district.AddAsync(district, cancellationToken);
        }

        public async ValueTask<Domain.DISTRICT> GetByDistrict_City_Country_Code(string districtCode,string cityCode, string countryCode,CancellationToken cancellation)
        {
            try {
                CITY target_city =  await _city.GetByCity_Country_Code(cityCode,countryCode,cancellation);
                if (target_city != null) {
                    return await _district
                                        .SingleOrDefaultAsync(d => d.CODE == districtCode && d.ID == target_city.ID, cancellationToken: cancellation);
                }
                else {
                    return new DISTRICT();
                }


            }
            catch (Exception)
            {
                    return new DISTRICT();
            }
        }

        public async ValueTask<IList<DISTRICT>> GetAllByCity_CountryCode(string cityCode, string countryCode,CancellationToken cancellation)
        {
            CITY result =  await _city.GetByCity_Country_Code(cityCode,countryCode,cancellation);

            
            return await _district
                            .AsNoTracking()
                            .Where(c=>c.ID == result.ID)
                            .ToListAsync(cancellation);
        }

       
    }
}
