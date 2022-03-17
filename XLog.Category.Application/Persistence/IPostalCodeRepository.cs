using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IPostalCodeRepository
    {
        //void SeedDatabase();
        void Remove(Domain.POSTALCODE postalCode);

        void Update(Domain.POSTALCODE postalCode);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        //ValueTask<Domain.PostalCode?> GetAsync(Guid id, CancellationToken cancellationToken);

        ValueTask AddAsync(Domain.POSTALCODE postalCode, CancellationToken cancellationToken);

        //IQueryable<Domain.PostalCode> GetPostalCodeQuery();
    }
}
