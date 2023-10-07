namespace Booking.API.Models
{
    /// <summary>
    /// Модель ответа сущности номера
    /// </summary>
    public class RoomResponse
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
        /// Тип номера
        /// </summary>
        public string TypeRoom { get; set; } = string.Empty;
    }
}
