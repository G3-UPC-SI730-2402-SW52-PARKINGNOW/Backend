using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.QueryServices;

public class AlertsQueryService(IAlertRepository alertRepository) : IAlertsQueryService
{
    public async Task<Alerts?> Handle(GetAlertByIdQuery query)
    {
        return await alertRepository.FindByIdAsync(query.id);
    }

    public async Task<IEnumerable<Alerts?>> Handle(GetAllAlertsQuery query)
    {
        return await alertRepository.ListAsync();
    }
}