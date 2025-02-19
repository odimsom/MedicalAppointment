
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities.System
{
    public sealed class Notifications : BaseEntity<int>
    {
        [Column("NotificationID")]
        [Key]
        public override int Id { get; set; }

        public int UserID { get; set; }

        public string Message { get; set; }

        public DateTime? SentAt { get; set; }
    }
}
