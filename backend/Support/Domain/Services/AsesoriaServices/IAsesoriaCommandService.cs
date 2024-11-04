using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.Commands.DeleteCommands;

namespace backend.Support.Domain.Services;

public interface IAsesoriaCommandService
{
    public Task<Asesoria?> Handle(CreateAsesoriaCommand command);
    public Task<Asesoria?> Handle(UpdateAsesoriaCommand command);
    void Handle(DeleteAsesoriaCommand command);
}