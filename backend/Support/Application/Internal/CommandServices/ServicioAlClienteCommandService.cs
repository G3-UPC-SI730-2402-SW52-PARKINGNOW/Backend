using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.CommandServices;

public class ServicioAlClienteCommandService(
    IServicioAlClienteRepository servicioAlClienteRepository,
    IUnitOfWork unitOfWork) : IServicioAlClienteCommandService
{
    public async Task<ServicioAlCliente?> Handle(CreateServicioAlClienteCommand command)
    {
        var servicioAlCliente = new ServicioAlCliente(command.clienteId, command.asunto);
        await servicioAlClienteRepository.AddAsync(servicioAlCliente);
        await unitOfWork.CompleteAsync();
        return servicioAlCliente;
    }

    public async Task<ServicioAlCliente> Handle(UpdateServicioAlClienteCommand command)
    {
        var servicioAlClient = await servicioAlClienteRepository.FindByIdAsync(command.id);
        if (servicioAlClient == null) return null;
        servicioAlClient.ClienteId = command.clienteId;
        servicioAlClient.Asunto = command.asunto;
        await unitOfWork.CompleteAsync();
        return servicioAlClient;
    }

    public void Handle(DeleteServicioAlClienteCommand command)
    {
        throw new NotImplementedException();
    }
}