using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Persistence
{
    public class RouteRepository : IRouteRepository
    {
        private readonly AppDbContext _categoryDbContext;
        private readonly DbSet<ROUTES> _route;


        public RouteRepository(AppDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
            _route = _categoryDbContext.Set<ROUTES>();
        }

        public void Remove(ROUTES route)
        {
            _route.Remove(route);
        }

        public void Update(ROUTES route)
        {
            _route.Update(route);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _categoryDbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask AddAsync(ROUTES route, CancellationToken cancellationToken)
        {
            await _route.AddAsync(route, cancellationToken);
        } 


        public async ValueTask<IEnumerable<ROUTES>> GetAll(CancellationToken cancellation)
        {
            return await _route
                                .AsNoTracking()
                                .ToListAsync(cancellation);
        }   
    }
}
