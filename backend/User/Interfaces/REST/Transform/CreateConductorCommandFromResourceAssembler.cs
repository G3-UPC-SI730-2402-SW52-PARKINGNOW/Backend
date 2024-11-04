using backend.User.Domain.Model.Commands;
using backend.User.Interfaces.REST.Resources;

namespace backend.User.Interfaces.REST.Transform;

public class CreateConductorCommandFromResourceAssembler
{
    public static CreateConductorCommand ToCommandFromResource(CreateConductorResource resource)
    {
        return new CreateConductorCommand(resource.Placa);
    }
}