using backend.Support.Domain.Model.Commands;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class CreateAsesoriaCommandFromResourceAssembler
{
    public static CreateAsesoriaCommand ToCommandFromResource(CreateAsesoriaResource resource)
    {
        return new CreateAsesoriaCommand(resource.clientId, resource.asunto);
    }
}