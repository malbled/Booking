using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;
using Booking.Repositories.Contracts.ReadInterfaces;


namespace Booking.Repositories.ReadRepositories
{
    /// <summary>
    /// Реализация <see cref="IServiceRenderedReadRepository"/>
    /// </summary>
    public class ServiceRenderedReadRepository : IServiceRenderedReadRepository
    {
        /// <summary>
        /// Контекст для связи с бд
        /// </summary>
        private IBookingContext context;

        public ServiceRenderedReadRepository(IBookingContext context)
        {
            this.context = context;
        }

        Task<List<ServiceRendered>> IServiceRenderedReadRepository.GetAllAsync(CancellationToken cancellationToken) =>
            Task.FromResult(context.ServicesRendered.ToList());

        Task<ServiceRendered?> IServiceRenderedReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
            Task.FromResult(context.ServicesRendered.FirstOrDefault(x => x.Id == id));
    }
}
