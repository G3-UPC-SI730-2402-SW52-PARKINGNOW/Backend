using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;

namespace backend.Support.Domain.Repositories;

public interface IAsesoriaRepository : IBaseRepository<Asesoria>
{
    Task<Asesoria?> FindByIdAsync(int id);
}