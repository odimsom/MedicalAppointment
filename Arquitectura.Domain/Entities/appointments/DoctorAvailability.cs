

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities.appointments
{
    public sealed class DoctorAvailability : BaseEntity<int>
    {
        [Column("AvailabilityID")]
        [Key]
        public override int Id { get; set; }

        public int DoctorID { get; set; }

        public DateOnly AvailableDate { get; set; }

        public Timer StartTime { get; set; }

        public Timer EndTime { get; set; }
    }
}
