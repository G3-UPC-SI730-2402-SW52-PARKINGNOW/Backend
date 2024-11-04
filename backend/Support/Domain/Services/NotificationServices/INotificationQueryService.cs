using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;

namespace backend.Support.Domain.Services;

public interface INotificationQueryService
{
    Task<Notification?> Handle(GetNotificationsByConductorQuery query);
    Task<IEnumerable<Notification?>> Handle(GetAllNotificationsQuery query);
}