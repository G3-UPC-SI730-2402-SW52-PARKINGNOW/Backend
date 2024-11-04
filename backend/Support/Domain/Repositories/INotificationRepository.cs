using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;

namespace backend.Support.Domain.Repositories;

public interface INotificationRepository : IBaseRepository<Notification>
{
    Task<Notification?> FindNotificationByConductorAsync(string conductorId);
}