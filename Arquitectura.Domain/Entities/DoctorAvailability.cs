

namespace Arquitectura.Domain.Entities
{
    public sealed class DoctorAvailability
    {
        public int AvailabilityID { get; set; }

        public int DoctorID { get; set; }

        public DateOnly AvailableDate { get; set; }

        public Timer StartTime { get; set; }

        public Timer EndTime { get; set; }
    }
}
