using Booking.Context.Contracts.Models;

namespace Booking.Repositories.Contracts.ReadInterfaces
{
    /// <summary>
    /// Репозиторий чтения <see cref="TypeRoom"/>
    /// </summary>
    public interface ITypeRoomReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="TypeRoom"/>
        /// </summary>
        Task<List<TypeRoom>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="TypeRoom"/> по идентификатору
        /// </summary>
        Task<TypeRoom?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="TypeRoom"/> по идентификаторам
        /// </summary>
        Task<List<TypeRoom>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken);
    }
}
