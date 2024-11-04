using backend.Shared.Domain.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.CommandServices;

public class AsesoriasCommandService(
    IAsesoriaRepository asesoriaRepository,
    IUnitOfWork unitOfWork) : IAsesoriaCommandService
{
    private IAsesoriaCommandService _asesoriaCommandServiceImplementation;

    public async Task<Asesoria?> Handle(CreateAsesoriaCommand command)
    {
        var asesoria = new Asesoria(command.clienteId, command.asunto);
        await asesoriaRepository.AddAsync(asesoria);
        await unitOfWork.CompleteAsync();
        return asesoria;
    }

    public async Task<Asesoria?> Handle(UpdateAsesoriaCommand command)
    {
        var asesoria = await asesoriaRepository.FindByIdAsync(command.id);
        if (asesoria == null) return null;
        asesoria.ClienteId = command.clienteId;
        asesoria.Asunto = command.asunto;
        await unitOfWork.CompleteAsync();
        return asesoria;
    }

    public void Handle(DeleteAsesoriaCommand command)
    {
        throw new NotImplementedException();
    }


}