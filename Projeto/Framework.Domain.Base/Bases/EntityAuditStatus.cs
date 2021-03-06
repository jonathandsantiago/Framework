using Framework.Domain.Base.Interfaces;
using System;

namespace Framework.Domain.Base
{
    public class EntityAuditStatus<TId> : EntityStatus<TId>, IEntityAuditStatus<TId>
    {
        public virtual string UserInsertion { get; set; }
        public virtual string UserEdition { get; set; }
        public virtual DateTime DateInsertion { get; set; }
        public virtual DateTime? DateEdition { get; set; }
        public virtual int Revision { get; set; }
    }
}