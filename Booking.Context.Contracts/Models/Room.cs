namespace Booking.Context.Contracts.Models
{
    /// <summary>
    /// Номера
    /// </summary>
    public class Room
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Индетификатор номера(номер номера)
        /// </summary>
        public string Identifier { get; set; } = string.Empty;

        /// <summary>
        /// Идентификатор типа номера
        /// </summary>
        public Guid TypeRoomId { get; set; }
    }
}
