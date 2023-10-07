using Booking.Context.Contracts.Models;

namespace Booking.Repositories.Contracts.ReadInterfaces
{
    /// <summary>
    /// Репозиторий чтения <see cref="BookingRoom"/>
    /// </summary>
    public interface IBookingRoomReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="BookingRoom"/>
        /// </summary>
        Task<List<BookingRoom>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="BookingRoom"/> по идентификатору
        /// </summary>
        Task<BookingRoom?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
