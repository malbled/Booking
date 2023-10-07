namespace Booking.Servises.Contracts.Models
{
    /// <summary>
    /// Модель классов номеров
    /// </summary>
    public class TypeRoomModel
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
