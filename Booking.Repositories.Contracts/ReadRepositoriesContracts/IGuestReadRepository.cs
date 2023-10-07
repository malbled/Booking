using Booking.Context.Contracts.Models;

namespace Booking.Repositories.Contracts.ReadInterfaces
{
    /// <summary>
    /// Репозиторий чтения <see cref="Guest"/>
    /// </summary>
    public interface IGuestReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Guest"/>
        /// </summary>
        Task<List<Guest>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Guest"/> по идентификатору
        /// </summary>
        Task<Guest?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Guest"/> по идентификаторам
        /// </summary>
        Task<List<Guest>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken);
    }
}
