using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.QueryServices;

public class NotificationQueryService(INotificationRepository notificationRepository) : INotificationQueryService
{
    public async Task<Notification?> Handle(GetNotificationsByConductorQuery query)
    {
        return await notificationRepository.FindByIdAsync(query.conductorId);
    }

    public async Task<IEnumerable<Notification?>> Handle(GetAllNotificationsQuery query)
    {
        return await notificationRepository.ListAsync();
    }
}