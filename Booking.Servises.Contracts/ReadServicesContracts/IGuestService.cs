using Booking.Servises.Contracts.Models;

namespace Booking.Servises.Contracts.ReadServicesContracts
{
    public interface IGuestService
    {
        /// <summary>
        /// Получить список всех <see cref="GuestModel"/>
        /// </summary>
        Task<IEnumerable<GuestModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="GuestModel"/> по идентификатору
        /// </summary>
        Task<GuestModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
