using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;

namespace backend.Support.Domain.Services;

public interface IAlertsCommandService
{
    public Task<Alerts?> Handle(CreateAlertCommand command);
    public Task<Alerts> Handle(UpdateAlertCommand command);
    void Handle(DeleteAlertCommand command);
}