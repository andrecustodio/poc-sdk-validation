using System;

namespace Sample.Domain.Base
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }
    }
}
