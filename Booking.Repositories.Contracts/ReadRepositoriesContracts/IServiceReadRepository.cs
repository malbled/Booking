using Booking.Context.Contracts.Models;

namespace Booking.Repositories.Contracts.ReadInterfaces
{
    /// <summary>
    /// Репозиторий чтения <see cref="Service"/>
    /// </summary>
    public interface IServiceReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Service"/>
        /// </summary>
        Task<List<Service>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Service"/> по идентификатору
        /// </summary>
        Task<Service?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Service"/> по идентификаторам
        /// </summary>
        Task<List<Service>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken);
    }
}
