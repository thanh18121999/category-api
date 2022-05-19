using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IWardRepository
    {
        //void SeedDatabase();
        void Remove(Domain.WARDS ward);

        void Update(Domain.WARDS ward);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.WARDS ward, CancellationToken cancellationToken);

        ValueTask<IEnumerable<Domain.WARDS?>> GetByWard_District_City_Country_Code(string wardCode,string districtCode,string cityCode, string countryCode,CancellationToken cancellation);
        ValueTask<IEnumerable<Domain.WARDS?>> GetAllByDistrict_City_CountryCode(string districtCode, string cityCode,string countryCode,CancellationToken cancellation);

    }
}
