

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities.System
{
    public sealed class Status : BaseEntity<int>
    {
        [Column("StatusID")]
        [Key]
        public override int Id { get; set; }

        public string StatusName { get; set; }
    }
}
