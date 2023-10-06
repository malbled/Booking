namespace Booking.Context.Contracts.Models
{
    /// <summary>
    /// Классы номеров
    /// </summary>
    public class TypeRoom
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование класса номера
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Цена за ночь
        /// </summary>
        public decimal Cost { get; set; }
    }
}
