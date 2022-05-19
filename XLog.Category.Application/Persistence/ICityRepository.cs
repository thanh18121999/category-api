using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface ICityRepository
    {
        //void SeedDatabase();
        void Remove(Domain.PROVINCES postalCode);

        void Update(Domain.PROVINCES postalCode);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.PROVINCES city, CancellationToken cancellationToken);

        ValueTask<IEnumerable<Domain.PROVINCES?>> GetAllByCountryCode(string countryCode, CancellationToken cancellation);

        ValueTask<IEnumerable<Domain.PROVINCES?>> GetByCity_Country_Code(string cityCode, string countryCode, CancellationToken cancellationToken);



    }
}
