using backend.Shared.Domain.Repositories;
using backend.User.Domain.Model.Aggregates;

namespace backend.User.Domain.Repositories;

public interface IUsuarioRepository : IBaseRepository<Usuario>
{
    Task<Usuario?> FindByDNIAync(string dni);
}