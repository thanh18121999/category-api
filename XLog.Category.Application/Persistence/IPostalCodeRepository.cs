using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IPostalCodeRepository
    {
        void Remove(Domain.POSTALCODE postalCode);

        void Update(Domain.POSTALCODE postalCode);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.POSTALCODE postalCode, CancellationToken cancellationToken);
        ValueTask <IEnumerable<Domain.POSTALCODE>> GetByCountry_City_District_Ward_Code(string countryCode,string cityCode,string districtCode,string wardCode, CancellationToken cancellationToken);

    }
}
