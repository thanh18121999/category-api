using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class UserGroupRepository : IUserGroupRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<USERGROUPS> _userGroup;


        public UserGroupRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _userGroup = _categoryDbContext.Set<USERGROUPS>();
        }

        public void Remove(USERGROUPS userGroup)
        {
            _userGroup.Remove(userGroup);
        }

        public void Update(USERGROUPS userGroup)
        {
            _userGroup.Update(userGroup);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(USERGROUPS userGroup, CancellationToken cancellationToken)
        {
            await _userGroup.AddAsync(userGroup, cancellationToken);
        } 


        public async ValueTask<IEnumerable<USERGROUPS>> GetAll(CancellationToken cancellation)
        {
            return await _userGroup
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }   
    }
}
