using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IDistrictRepository
    {
        //void SeedDatabase();
        void Remove(Domain.DISTRICT district);

        void Update(Domain.DISTRICT district);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.DISTRICT district, CancellationToken cancellationToken);

        ValueTask<Domain.DISTRICT> GetByDistrict_City_Country_Code(string districtCode,string cityCode, string countryCode,CancellationToken cancellation);

        ValueTask<IList<Domain.DISTRICT>> GetAllByCity_CountryCode(string cityCode,string countryCode,CancellationToken cancellation);

    }
}
