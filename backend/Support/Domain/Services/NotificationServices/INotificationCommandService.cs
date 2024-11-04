using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;

namespace backend.Support.Domain.Services;

public interface INotificationCommandService
{
    public Task<Notification?> Handle(CreateNotificationCommand command);
    public Task<Notification> Handle(UpdateNotificationCommand command);
    void Handle(DeleteNotificationCommand command);
}