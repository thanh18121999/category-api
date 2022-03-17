using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface ICityRepository
    {
        //void SeedDatabase();
        void Remove(Domain.CITY postalCode);

        void Update(Domain.CITY postalCode);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.CITY city, CancellationToken cancellationToken);

        ValueTask<IList<Domain.CITY>> GetAllByCountryCode(string countryCode, CancellationToken cancellation);

        ValueTask<Domain.CITY?> GetByCity_Country_Code(string cityCode, string countryCode, CancellationToken cancellationToken);



    }
}
