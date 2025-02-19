

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities.users
{
    public sealed class Doctors : MedicalAppointmentBaseEntity<int>
    {
        [Column("DoctorID")]
        [Key]
        public override int Id { get; set; }

        public int SpecialtyID { get; set; }

        public string LicenseNumber { get; set; }

        public string PhoneNumber { get; set; }

        public int YearsOfExperience { get; set; }

        public string Education { get; set; }

        public string? Bio { get; set; }

        public decimal? ConsultationFee { get; set; }

        public string? ClinicAddress { get; set; }

        public int? AvailabilityModeId { get; set; }

        public DateOnly LicenseExpirationDate { get; set; }

    }
}
