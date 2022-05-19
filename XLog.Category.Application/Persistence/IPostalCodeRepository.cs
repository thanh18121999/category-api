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

        // ValueTask<IEnumerable<Domain.POSTALCODE?>> GetBy_Ward_District_City_Country_Code(string wardCode, string districtCode,string cityCode, string countryCode,CancellationToken cancellationToken);
        // ValueTask<IEnumerable<Domain.DISTRICTS?>> GetAllByWard_City_CountryCode(string cityCode,string countryCode,CancellationToken cancellation);
        // ValueTask<IEnumerable<Domain.POSTALCODE?>> Get_Ward_District_City_Country_ByPostalCode(string postalCode,CancellationToken cancellationToken);
    }
}
