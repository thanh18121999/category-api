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
        private readonly DbSet<Ward> _Ward;
        private readonly IDistrictRepository _district;

        public WardRepository(AppDbContext categoryDbContext, IDistrictRepository districtRepository)
        {
            _categoryDbContext = categoryDbContext;
            _Ward = _categoryDbContext.Set<Ward>();
            _district = districtRepository;

        }

        public void Remove(Ward Ward)
        {
            _Ward.Remove(Ward);
        }

        public void Update(Ward Ward)
        {
            _Ward.Update(Ward);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(Ward Ward, CancellationToken cancellationToken)
        {
            await _Ward.AddAsync(Ward, cancellationToken);
        }

        public async ValueTask<Domain.Ward> GetByWard_District_City_Country_Code(string wardCode,string districtCode,string cityCode, string countryCode,CancellationToken cancellation)
        {
            try {
                DISTRICT target_district =  await _district.GetByDistrict_City_Country_Code(districtCode,cityCode,countryCode,cancellation);
                if (target_district != null) {
                    return await _Ward
                                        .SingleOrDefaultAsync(d => d.Code == wardCode&& d.DISTRICTID == target_district.ID, cancellationToken: cancellation);
                }
                else {
                    return new Ward();
                }


            }
            catch (Exception)
            {
                    return new Ward();
            }
        }

        public async ValueTask<IList<Ward>> GetAllByDistrict_City_CountryCode(string districtCode,string cityCode, string countryCode,CancellationToken cancellation)
        {
            DISTRICT result =  await _district.GetByDistrict_City_Country_Code(districtCode,cityCode,countryCode,cancellation);

            
            return await _Ward
                            .AsNoTracking()
                            .Where(c=>c.DISTRICTID == result.ID)
                            .ToListAsync(cancellation);
        }

       
    }
}
