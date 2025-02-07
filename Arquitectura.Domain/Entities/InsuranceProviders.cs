
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class InsuranceProviders : MedicalAppointmentBaseEntity
    {
        [Column("InsuranceProviderID")]
        [Key]
        public override int Id { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public string? Website { get; set; }

        public string Addres { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public string? ZipCode { get; set; }

        public string CoverageDetails { get; set; }

        public string? LogoUrl { get; set; }

        public bool IsPreferred { get; set; }

        public int NetworkTypeId { get; set; }

        public string? CustomerSupportContact { get; set; }

        public string? AcceptedRegions { get; set; }

        public Decimal? MaxCoverageAmount { get; set; }
    }
}
