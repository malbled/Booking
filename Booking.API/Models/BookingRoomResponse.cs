namespace Booking.API.Models
{
    /// <summary>
    /// Модель ответа сущности забронированного номера
    /// </summary>
    public class BookingRoomResponse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор номера
        /// </summary>
        public string RoomIdentifier{ get; set; } = string.Empty;

        /// <summary>
        /// фио ПОСТОЯЛЬЦА
        /// </summary>
        public string GuestFIO { get; set; } = string.Empty;

        /// <summary>
        /// номер постояльца
        /// </summary>
        public string GuestPhone { get; set; } = string.Empty;

        /// <summary>
        /// Дата заселения
        /// </summary>
        public DateTimeOffset DateCheckIn { get; set; }

        /// <summary>
        /// Дата выселения
        /// </summary>
        public DateTimeOffset DateCheckOut { get; set; }
    }
}
