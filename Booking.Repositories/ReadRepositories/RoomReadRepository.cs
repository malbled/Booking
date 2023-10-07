using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;
using Booking.Repositories.Contracts.ReadInterfaces;

namespace Booking.Repositories.ReadRepositories
{
    /// <summary>
    /// Реализация <see cref="IRoomReadRepository"/>
    /// </summary>
    public class RoomReadRepository : IRoomReadRepository
    {
        /// <summary>
        /// Контекст для связи с бд
        /// </summary>
        private IBookingContext context;

        public RoomReadRepository(IBookingContext context)
        {
            this.context = context;
        }

        Task<List<Room>> IRoomReadRepository.GetAllAsync(CancellationToken cancellationToken) =>
            Task.FromResult(context.Rooms.ToList());

        Task<Room?> IRoomReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
            Task.FromResult(context.Rooms.FirstOrDefault(x => x.Id == id));

        Task<List<Room>> IRoomReadRepository.GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken) =>
            Task.FromResult(context.Rooms.Where(x => ids.Contains(x.Id)).ToList());
    }
}
