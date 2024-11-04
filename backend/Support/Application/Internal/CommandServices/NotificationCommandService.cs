using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.CommandServices;

public class NotificationCommandService(
    INotificationRepository notificationRepository,
    IUnitOfWork unitOfWork) : INotificationCommandService
{
    public async Task<Notification?> Handle(CreateNotificationCommand command)
    {
        var notification = new Notification(command.conductorId, command.mensaje, command.leido);
        await notificationRepository.AddAsync(notification);
        await unitOfWork.CompleteAsync();
        return notification;
    }

    public async Task<Notification> Handle(UpdateNotificationCommand command)
    {
        var notification = await notificationRepository.FindByIdAsync(command.id);
        if (notification == null) return null;
        notification.ConductorId = command.conductorId;
        notification.Mensaje = command.mensaje;
        notification.Leido = command.leido;
        await unitOfWork.CompleteAsync();
        return notification;
    }

    public void Handle(DeleteNotificationCommand command)
    {
        throw new NotImplementedException();
    }
}