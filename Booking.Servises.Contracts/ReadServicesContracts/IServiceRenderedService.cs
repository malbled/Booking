using Booking.Servises.Contracts.Models;

namespace Booking.Servises.Contracts.ReadServicesContracts
{
    public interface IServiceRenderedService
    {
        /// <summary>
        /// Получить список всех <see cref="ServiceRenderedModel"/>
        /// </summary>
        Task<IEnumerable<ServiceRenderedModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="ServiceRenderedModel"/> по идентификатору
        /// </summary>
        Task<ServiceRenderedModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
