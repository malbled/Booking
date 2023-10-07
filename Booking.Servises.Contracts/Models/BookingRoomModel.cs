namespace Booking.Servises.Contracts.Models
{
    /// <summary>
    /// Модель брони номера
    /// </summary>
    public class BookingRoomModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор номера
        /// </summary>
        public RoomModel? RoomId { get; set; }

        /// <summary>
        /// Идентификатор постояльца
        /// </summary>
        public GuestModel? GuestId { get; set; }

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
