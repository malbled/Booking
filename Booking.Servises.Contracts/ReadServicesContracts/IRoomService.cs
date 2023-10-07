using Booking.Servises.Contracts.Models;

namespace Booking.Servises.Contracts.ReadServicesContracts
{
    public interface IRoomService
    {
        /// <summary>
        /// Получить список всех <see cref="RoomModel"/>
        /// </summary>
        Task<IEnumerable<RoomModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="RoomModel"/> по идентификатору
        /// </summary>
        Task<RoomModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
