using AdminCentralDemo.Domain.Audit;
using System.ComponentModel.DataAnnotations;

namespace AdminCentralDemo.Domain.Entities
{
    public class User : BaseEntity, IAuditableEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }

        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? Password { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }


        [Required]
        public long RoleId { get; set; }
        public Role? Role { get; set; }

        public bool IsActive { get; set; } = true;
        public long? CreatedById { get; set; }
        public long? ModifiedById { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? ModifiedAt { get; set; }
        public User? CreatedBy { get; set; }
        public User? ModifiedBy { get; set; }
    }
}
