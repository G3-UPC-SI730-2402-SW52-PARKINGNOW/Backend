using backend.Shared.Domain.Repositories;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Commands;
using backend.User.Domain.Repositories;
using backend.User.Domain.Services;

namespace backend.User.Application.Internal.CommandServices;

public class ConductorCommandService(
    IConductorRepository conductorRepository,
    IUnitOfWork unitOfWork) : IConductorCommandService
{
    public async Task<Conductor?> Handle(CreateConductorCommand command)
    {
        var conductor = new Conductor(command.placa);
        await conductorRepository.AddAsync(conductor);
        await unitOfWork.CompleteAsync();
        return conductor;
    }
}