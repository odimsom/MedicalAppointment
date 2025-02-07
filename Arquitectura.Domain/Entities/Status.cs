

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class Status : Base.BaseEntity<int>
    {
        [Column("StatusID")]
        [Key]
        public override int Id { get; set; }

        public string StatusName { get; set; }
    }
}
