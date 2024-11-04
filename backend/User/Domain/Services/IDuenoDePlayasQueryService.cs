using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Queries;

namespace backend.User.Domain.Services;

public interface IDuenoDePlayasQueryService
{
    Task<DuenoDePlayas?> Handle(GetDuenoDePlayasByRUCQuery query);
}