using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;

namespace backend.Support.Domain.Repositories;

public interface IAlertRepository : IBaseRepository<Alerts>
{
    Task<Alerts?> FindByIdAsync(int id);
}