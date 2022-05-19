using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IDistrictRepository
    {
        //void SeedDatabase();
        void Remove(Domain.DISTRICTS district);

        void Update(Domain.DISTRICTS district);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.DISTRICTS district, CancellationToken cancellationToken);

        ValueTask<IEnumerable<Domain.DISTRICTS?>> GetByDistrict_City_Country_Code(string districtCode,string cityCode, string countryCode,CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.DISTRICTS?>> GetAllByCity_CountryCode(string cityCode,string countryCode,CancellationToken cancellation);

    }
}
