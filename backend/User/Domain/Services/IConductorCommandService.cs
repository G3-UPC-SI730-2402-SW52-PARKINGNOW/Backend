using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Commands;

namespace backend.User.Domain.Services;

public interface IConductorCommandService
{
    public Task<Conductor?> Handle(CreateConductorCommand command);
}