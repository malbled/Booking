using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;
using Booking.Repositories.Contracts.ReadInterfaces;

namespace Booking.Repositories.ReadRepositories
{
    /// <summary>
    /// Реализация <see cref="IGuestReadRepository"/>
    /// </summary>
    public class GuestReadRepository : IGuestReadRepository
    {
        /// <summary>
        /// Контекст для связи с бд
        /// </summary>
        private IBookingContext context;

        public GuestReadRepository(IBookingContext context)
        {
            this.context = context;
        }

        Task<List<Guest>> IGuestReadRepository.GetAllAsync(CancellationToken cancellationToken) =>
            Task.FromResult(context.Guests.ToList());

        Task<Guest?> IGuestReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
            Task.FromResult(context.Guests.FirstOrDefault(x => x.Id == id));

        Task<List<Guest>> IGuestReadRepository.GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken) =>
            Task.FromResult(context.Guests.Where(x => ids.Contains(x.Id)).ToList());
    }
}
