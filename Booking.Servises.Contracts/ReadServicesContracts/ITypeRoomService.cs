using Booking.Servises.Contracts.Models;

namespace Booking.Servises.Contracts.ReadServicesContracts
{
    public interface ITypeRoomService
    {
        /// <summary>
        /// Получить список всех <see cref="TypeRoomModel"/>
        /// </summary>
        Task<IEnumerable<TypeRoomModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="TypeRoomModel"/> по идентификатору
        /// </summary>
        Task<TypeRoomModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
