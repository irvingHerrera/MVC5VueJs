using Common;
using Common.CustomFilters;
using Model.Helper;

namespace Model.Domain
{
    public class Income : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public Enums.EntityType EntityType { get; set; }
        public Enums.IncomeType IncomeType { get; set; }
        public decimal Total { get; set; }
        public int EntityId { get; set; }

        public bool Deleted { get; set; }
    }
}
