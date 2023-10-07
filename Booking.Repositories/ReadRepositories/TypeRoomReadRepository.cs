using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;
using Booking.Repositories.Contracts.ReadInterfaces;

namespace Booking.Repositories.ReadRepositories
{
    /// <summary>
    /// Реализация <see cref="ITypeRoomReadRepository"/>
    /// </summary>
    public class TypeRoomReadRepository : ITypeRoomReadRepository
    {
        /// <summary>
        /// Контекст для связи с бд
        /// </summary>
        private IBookingContext context;

        public TypeRoomReadRepository(IBookingContext context)
        {
            this.context = context;
        }

        Task<List<TypeRoom>> ITypeRoomReadRepository.GetAllAsync(CancellationToken cancellationToken) =>
            Task.FromResult(context.TypesRooms.ToList());

        Task<TypeRoom?> ITypeRoomReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
            Task.FromResult(context.TypesRooms.FirstOrDefault(x => x.Id == id));

        Task<List<TypeRoom>> ITypeRoomReadRepository.GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken) =>
            Task.FromResult(context.TypesRooms.Where(x => ids.Contains(x.Id)).ToList());
    }
}
