using backend.Shared.Domain.Repositories;
using backend.User.Domain.Model.Aggregates;

namespace backend.User.Domain.Repositories;

public interface IConductorRepository : IBaseRepository<Conductor>
{
    Task<Conductor?> FindByPlacaAync(string placa);
}