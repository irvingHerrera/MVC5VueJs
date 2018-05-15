using Common.CustomFilters;
using Model.Helper;

namespace Model.Domain
{
    public class Category: AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }

        public bool Deleted { get; set; }
    }
}
