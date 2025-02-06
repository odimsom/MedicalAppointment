
namespace Arquitectura.Domain.Entities
{
    public sealed class Notifications
    {
        public int NotificationID { get; set; }

        public int UserID { get; set; }

        public string Message { get; set; }

        public DateTime? SentAt { get; set; }
    }
}
