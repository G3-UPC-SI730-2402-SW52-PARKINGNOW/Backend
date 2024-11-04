using backend.Shared.Domain.Repositories;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Commands;
using backend.User.Domain.Repositories;
using backend.User.Domain.Services;

namespace backend.User.Application.Internal.CommandServices;

public class UsuarioCommandService(
    IUsuarioRepository usuarioRepository,
    IUnitOfWork unitOfWork) : IUsuarioCommandService
{
    public async Task<Usuario?> Handle(CreateUsuarioCommand command)
    {
        var usuario = new Usuario(command.fullname, command.age, command.dni, command.rol);
        await usuarioRepository.AddAsync(usuario);
        await unitOfWork.CompleteAsync();
        return usuario;
    }
}