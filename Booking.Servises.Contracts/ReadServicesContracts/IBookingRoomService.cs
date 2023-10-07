using Booking.Servises.Contracts.Models;

namespace Booking.Servises.Contracts.ReadServicesContracts
{
    public interface IBookingRoomService
    {
        /// <summary>
        /// Получить список всех <see cref="BookingRoomModel"/>
        /// </summary>
        Task<IEnumerable<BookingRoomModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="BookingRoomModel"/> по идентификатору
        /// </summary>
        Task<BookingRoomModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
