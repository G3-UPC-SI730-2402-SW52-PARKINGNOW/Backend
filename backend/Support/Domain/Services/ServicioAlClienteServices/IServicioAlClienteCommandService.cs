using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;

namespace backend.Support.Domain.Services;

public interface IServicioAlClienteCommandService
{
    public Task<ServicioAlCliente?> Handle(CreateServicioAlClienteCommand command);
    public Task<ServicioAlCliente> Handle(UpdateServicioAlClienteCommand command);
    void Handle(DeleteServicioAlClienteCommand command);
}