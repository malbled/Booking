using Booking.Context.Contracts.Models;

namespace Booking.Repositories.Contracts.ReadInterfaces
{
    /// <summary>
    /// Репозиторий чтения <see cref="Room"/>
    /// </summary>
    public interface IRoomReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Room"/>
        /// </summary>
        Task<List<Room>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Room"/> по идентификатору
        /// </summary>
        Task<Room?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Room"/> по идентификаторам
        /// </summary>
        Task<List<Room>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken);
    }
}
