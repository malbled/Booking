namespace Booking.Context.Contracts.Models
{
    /// <summary>
    /// Бронь номеров
    /// </summary>
    public class BookingRoom
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор номера
        /// </summary>
        public Guid RoomId { get; set; }

        /// <summary>
        /// Идентификатор постояльца
        /// </summary>
        public Guid GuestId { get; set; }

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
