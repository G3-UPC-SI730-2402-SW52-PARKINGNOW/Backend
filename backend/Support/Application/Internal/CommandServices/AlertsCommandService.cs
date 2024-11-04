using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.CommandServices;

public class AlertsCommandService(
    IAlertRepository alertRepository,
    IUnitOfWork unitOfWork) : IAlertsCommandService
{
    public async Task<Alerts?> Handle(CreateAlertCommand command)
    {
        var alert = new Alerts(command.mensaje, command.activo);
        await alertRepository.AddAsync(alert);
        await unitOfWork.CompleteAsync();
        return alert;
    }

    public async Task<Alerts> Handle(UpdateAlertCommand command)
    {
        var alert = await alertRepository.FindByIdAsync(command.id);
        if (alert == null) return null;
        alert.Mensaje = command.mensaje;
        alert.Activo = command.activo;
        await unitOfWork.CompleteAsync();
        return alert;
    }

    public void Handle(DeleteAlertCommand command)
    {
        throw new NotImplementedException();
    }
}