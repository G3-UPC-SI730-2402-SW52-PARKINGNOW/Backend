using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Commands;
using backend.User.Domain.Model.Queries;

namespace backend.User.Domain.Services;

public interface IDuenoDePlayasCommandService
{
    Task<DuenoDePlayas?> Handle(CreateDuenoDePlayasCommand command);
}