using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Commands;

namespace backend.User.Domain.Services;

public interface IUsuarioCommandService
{
    public Task<Usuario?> Handle(CreateUsuarioCommand command);
}