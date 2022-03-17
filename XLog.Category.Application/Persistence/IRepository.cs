using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XLog.Category.Domain;

namespace XLog.Core.Persistence
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Remove(T entity);

        void Update(T entity);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        ValueTask<T> GetAsync(string id, CancellationToken cancellationToken);

        ValueTask AddAsync(T entity, CancellationToken cancellationToken);

        ValueTask<int> CountAsync(CancellationToken cancellationToken);

        ValueTask<IList<T>> ToListAsync(CancellationToken cancellationToken);

        ValueTask<IList<T>> SearchAsync(string filter, int pageIndex, int pageSize, CancellationToken cancellationToken);


        #region EFCore BULK EXTENSIONS
        //void BulkInsert<T>(IList<T> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null) where T : class;
        void BulkInsert<T>(IList<T> entities, Action<decimal> progress = null) where T : class;

        #endregion


    }
}

