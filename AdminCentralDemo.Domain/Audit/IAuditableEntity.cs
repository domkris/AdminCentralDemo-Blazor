using AdminCentralDemo.Domain.Entities;

namespace AdminCentralDemo.Domain.Audit
{
    public interface IAuditableEntity
    {
        long? CreatedById { get; set; }
        User? CreatedBy { get; set; }
        long ? ModifiedById { get; set; }
        User? ModifiedBy { get; set; }
        DateTimeOffset? CreatedAt { get; set; }
        DateTimeOffset? ModifiedAt { get; set; }
    }
}
