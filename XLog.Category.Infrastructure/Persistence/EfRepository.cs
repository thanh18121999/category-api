using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XLog.Category.Domain;
//using XLog.Category.Infrastructure.Persistence;
using XLog.Core.Persistence;
//using XLog.Infrastructure.Common;
//using XLog.Infrastructure.Data.DbProviders.Oracle;

namespace XLog.Infrastructure.Persistence
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly XLog.Category.Infrastructure.Persistence.AppDbContext _dbContext;
        protected DbSet<T> DbSet { get; }
        public EfRepository(XLog.Category.Infrastructure.Persistence.AppDbContext dbContext)
        {
            this._dbContext = dbContext;
            this.DbSet = _dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();

        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask<T> GetAsync(string id, CancellationToken cancellationToken)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async ValueTask<IList<T>> ToListAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Set<T>()
                                  .AsNoTracking()
                                  //.OrderBy(x => x.NAME)
                                  //.Skip((pageIndex - 1) * pageSize)
                                  //.Take(pageSize)
                                 //.Include(x => x.Store)
                                 .ToListAsync(cancellationToken);
        }


        public async ValueTask AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _dbContext.Set<T>().AddAsync(entity, cancellationToken);
        }

        public async ValueTask<int> CountAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Set<T>().CountAsync(cancellationToken);
        }

        public async ValueTask<IList<T>> SearchAsync(string filter,
                                                                   int pageIndex,
                                                                   int pageSize,
                                                                   CancellationToken cancellation)
        {
            return await _dbContext.Set<T>()
                                  .AsNoTracking()
                                  //.Where(x => x.Name.Contains(filter) || x.Code.Contains(filter))
                                  //.OrderBy(x => x.NAME)
                                  //.Skip((pageIndex - 1) * pageSize)
                                  .Take(pageSize)
                                 //.Include(x => x.Store)
                                 .ToListAsync(cancellation);
        }



        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //#region EFCore BULK EXTENSIONS
        public virtual void BulkInsert<T>(IList<T> entities, Action<decimal> progress = null) where T : class
        {
            //var properties = typeof(T).GetProperties();
            //var table = new DataTable();

            //foreach (var property in properties)
            //{
            //    var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
            //    table.Columns.Add(property.Name, type);
            //}
            //foreach (var entity in entities)
            //{
            //    table.Rows.Add(properties.Select(p => p.GetValue(entity, null)).ToArray());
            //}

            //table.TableName = TableInfo.TableName<T>();

            //BulkCopy bulk = new BulkCopy(_dbContext.Database.GetConnectionString());

            //bulk.BulkInsert(table);
        }





        //#endregion
    }
}

