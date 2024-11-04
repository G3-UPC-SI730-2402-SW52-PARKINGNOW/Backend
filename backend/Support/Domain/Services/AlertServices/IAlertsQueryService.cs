using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;

namespace backend.Support.Domain.Services;

public interface IAlertsQueryService
{
    Task<Alerts?> Handle(GetAlertByIdQuery query);
    Task<IEnumerable<Alerts?>> Handle(GetAllAlertsQuery query);
}