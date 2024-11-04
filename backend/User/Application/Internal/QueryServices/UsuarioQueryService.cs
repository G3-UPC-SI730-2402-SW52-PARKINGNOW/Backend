using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Queries;
using backend.User.Domain.Repositories;
using backend.User.Domain.Services;

namespace backend.User.Application.Internal.QueryServices;

public class UsuarioQueryService(IUsuarioRepository usuarioRepository) : IUsuarioQueryService
{
    public async Task<Usuario?> Handle(GetUsuarioByIdQuery query)
    {
        return await usuarioRepository.FindByIdAsync(query.id);
    }

    public async Task<Usuario?> Handle(GetUsuarioByDNIQuery query)
    {
        return await usuarioRepository.FindByDNIAync(query.dni);
    }

    public async Task<IEnumerable<Usuario>> Handle(GetAllUsuariosQuery query)
    {
        return await usuarioRepository.ListAsync();
    }
}