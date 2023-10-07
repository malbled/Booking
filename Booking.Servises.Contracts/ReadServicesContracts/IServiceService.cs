﻿using Booking.Servises.Contracts.Models;

namespace Booking.Servises.Contracts.ReadServicesContracts
{
    public interface IServiceService
    {
        /// <summary>
        /// Получить список всех <see cref="ServiceModel"/>
        /// </summary>
        Task<IEnumerable<ServiceModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="ServiceModel"/> по идентификатору
        /// </summary>
        Task<ServiceModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
