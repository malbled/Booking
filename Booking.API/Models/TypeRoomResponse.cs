namespace Booking.API.Models
{
    /// <summary>
    /// Модель ответа сущности Типов класса
    /// </summary>
    public class TypeRoomResponse
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
