using Booking.Context.Contracts.Models;

namespace Booking.Repositories.Contracts.ReadInterfaces
{
    /// <summary>
    /// Репозиторий чтения <see cref="ServiceRendered"/>
    /// </summary>
    public interface IServiceRenderedReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="ServiceRendered"/>
        /// </summary>
        Task<List<ServiceRendered>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="ServiceRendered"/> по идентификатору
        /// </summary>
        Task<ServiceRendered?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
