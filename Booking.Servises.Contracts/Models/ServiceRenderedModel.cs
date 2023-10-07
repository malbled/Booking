namespace Booking.Servises.Contracts.Models
{
    /// <summary>
    /// Модель оказанной услуги
    /// </summary>
    public class ServiceRenderedModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public ServiceModel? ServiceId { get; set; }

        /// <summary>
        /// Идентификатор постояльца
        /// </summary>
        public GuestModel? GuestId { get; set; }

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
