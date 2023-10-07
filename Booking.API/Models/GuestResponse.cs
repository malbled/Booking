namespace Booking.API.Models
{
    /// <summary>
    /// Модель ответа сущности постояльца
    /// </summary>
    public class GuestResponse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; } = string.Empty;

        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string Passport { get; set; } = string.Empty;

        /// <summary>
        /// Номер теелфона
        /// </summary>
        public string Telephone { get; set; } = string.Empty;
    }
}
