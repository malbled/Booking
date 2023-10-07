namespace Booking.Servises.Contracts.Models
{
    /// <summary>
    /// Модель номера
    /// </summary>
    public class RoomModel
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
        public TypeRoomModel? TypeRoomId { get; set; }
    }
}
