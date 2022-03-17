using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IWardRepository
    {
        //void SeedDatabase();
        void Remove(Domain.Ward ward);

        void Update(Domain.Ward ward);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.Ward ward, CancellationToken cancellationToken);

        ValueTask<Domain.Ward> GetByWard_District_City_Country_Code(string wardCode,string districtCode,string cityCode, string countryCode,CancellationToken cancellation);

        ValueTask<IList<Domain.Ward>> GetAllByDistrict_City_CountryCode(string districtCode, string cityCode,string countryCode,CancellationToken cancellation);

    }
}
