using backend.Shared.Domain.Repositories;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Commands;
using backend.User.Domain.Repositories;
using backend.User.Domain.Services;

namespace backend.User.Application.Internal.CommandServices;

public class DuenoDePlayasCommandService(
    IDuenoDePlayasRepository duenoDePlayasRepository,
    IUnitOfWork unitOfWork) : IDuenoDePlayasCommandService
{
    public async Task<DuenoDePlayas?> Handle(CreateDuenoDePlayasCommand command)
    {
        var duenoDePlayas = new DuenoDePlayas(command.ruc, command.phoneNumber, command.email);
        await duenoDePlayasRepository.AddAsync(duenoDePlayas);
        await unitOfWork.CompleteAsync();
        return duenoDePlayas;
    }
}