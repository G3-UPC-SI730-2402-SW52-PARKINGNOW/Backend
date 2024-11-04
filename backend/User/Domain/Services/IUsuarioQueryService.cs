using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Queries;

namespace backend.User.Domain.Services;

public interface IUsuarioQueryService
{
    Task<Usuario?> Handle(GetUsuarioByIdQuery query);
    Task<Usuario?> Handle(GetUsuarioByDNIQuery query);
    Task<IEnumerable<Usuario>> Handle(GetAllUsuariosQuery query);
}