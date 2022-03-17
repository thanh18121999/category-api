using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface ICountryRepository
    {
        //void SeedDatabase();
        void Remove(Domain.COUNTRY postalCode);
        void Update(Domain.COUNTRY postalCode);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.COUNTRY country, CancellationToken cancellationToken);
        ValueTask<Domain.COUNTRY?> GetById(string countryId, CancellationToken cancellationToken);
        ValueTask<Domain.COUNTRY?> GetByCode(string countryCode, CancellationToken cancellationToken);
        ValueTask<IList<Domain.COUNTRY>> GetAll(CancellationToken cancellation);

    }
}
