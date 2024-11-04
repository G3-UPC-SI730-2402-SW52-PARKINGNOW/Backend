using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;

namespace backend.Support.Domain.Repositories;

public interface IServicioAlClienteRepository : IBaseRepository<ServicioAlCliente>
{
    Task<ServicioAlCliente?> FindByIdAsync(int id);
}