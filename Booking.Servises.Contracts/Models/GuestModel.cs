namespace Booking.Servises.Contracts.Models
{
    /// <summary>
    /// Модель постояльца
    /// </summary>
    public class GuestModel
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
