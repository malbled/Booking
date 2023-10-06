namespace Booking.Context.Contracts.Models
{
    /// <summary>
    /// Оказанные услуги
    /// </summary>
    public class ServiceRendered
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Идентификатор постояльца
        /// </summary>
        public Guid GuestId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Дата оказания
        /// </summary>
        public DateTimeOffset DateRend { get; set; }
    }
}
