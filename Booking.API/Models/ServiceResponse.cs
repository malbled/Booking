namespace Booking.API.Models
{
    /// <summary>
    /// Модель ответа сущности услуг
    /// </summary>
    public class ServiceResponse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование услуги
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание услуги
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Цена услуги
        /// </summary>
        public decimal Cost { get; set; }
    }
}
