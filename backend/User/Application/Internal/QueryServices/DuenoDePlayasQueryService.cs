using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Queries;
using backend.User.Domain.Repositories;
using backend.User.Domain.Services;

namespace backend.User.Application.Internal.QueryServices;

public class DuenoDePlayasQueryService(IDuenoDePlayasRepository duenoDePlayasRepository) : IDuenoDePlayasQueryService
{
    private IDuenoDePlayasCommandService _duenoDePlayasCommandServiceImplementation;

    public async Task<DuenoDePlayas?> Handle(GetDuenoDePlayasByRUCQuery query)
    {
        return await duenoDePlayasRepository.FindByRUCAsync(query.RUC);
    }
}