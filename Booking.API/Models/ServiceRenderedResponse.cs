namespace Booking.API.Models
{
    /// <summary>
    /// Модель ответа сущности оказанных услуг
    /// </summary>
    public class ServiceRenderedResponse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ИНаименование услуги
        /// </summary>
        public string ServiceName { get; set; } = string.Empty;

        /// <summary>
        /// фИО постояльца
        /// </summary>
        public string GuestFIO { get; set; } = string.Empty;

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
