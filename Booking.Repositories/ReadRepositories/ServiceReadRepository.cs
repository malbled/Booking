using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;
using Booking.Repositories.Contracts.ReadInterfaces;

namespace Booking.Repositories.ReadRepositories
{
    /// <summary>
    /// Реализация <see cref="IServiceReadRepository"/>
    /// </summary>
    public class ServiceReadRepository : IServiceReadRepository
    {
        /// <summary>
        /// Контекст для связи с бд
        /// </summary>
        private IBookingContext context;

        public ServiceReadRepository(IBookingContext context)
        {
            this.context = context;
        }

        Task<List<Service>> IServiceReadRepository.GetAllAsync(CancellationToken cancellationToken) =>
            Task.FromResult(context.Services.ToList());

        Task<Service?> IServiceReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
            Task.FromResult(context.Services.FirstOrDefault(x => x.Id == id));

        Task<List<Service>> IServiceReadRepository.GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken) =>
            Task.FromResult(context.Services.Where(x => ids.Contains(x.Id)).ToList());
    }
}
