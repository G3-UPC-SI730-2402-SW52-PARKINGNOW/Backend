using backend.Shared.Domain.Repositories;
using backend.User.Domain.Model.Aggregates;

namespace backend.User.Domain.Repositories;

public interface IDuenoDePlayasRepository : IBaseRepository<DuenoDePlayas>
{
    Task<DuenoDePlayas?> FindByRUCAsync(string Ruc);
}