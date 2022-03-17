using System;
using System.Collections.Generic;

namespace XLog.Category.Domain
{
    public abstract class BaseEntity<TId> : BaseEntity
    {
        public virtual TId ID { get; set; }

        protected BaseEntity(TId id)
        {
            ID = id;
        }

        // EF requires an empty constructor
        protected BaseEntity()
        {
        }
    }

    public abstract class BaseEntity
    {
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}

