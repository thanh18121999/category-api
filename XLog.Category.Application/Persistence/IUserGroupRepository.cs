using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace XLog.Category.Application.Persistence
{
    public interface IUserGroupRepository
    {
        //void SeedDatabase();
        void Remove(Domain.USERGROUPS userGroup);
        void Update(Domain.USERGROUPS userGroup);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        ValueTask AddAsync(Domain.USERGROUPS userGroup, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Domain.USERGROUPS>> GetAll(CancellationToken cancellation);
    }
}
