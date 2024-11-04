using backend.User.Domain.Model.Commands;
using backend.User.Interfaces.REST.Resources;

namespace backend.User.Interfaces.REST.Transform;

public class CreateDuenoDePlayasCommandFromResourceAssembler
{
    public static CreateDuenoDePlayasCommand ToCommandFromResource(CreateDuenoDePlayasResource resource)
    {
        return new CreateDuenoDePlayasCommand(resource.RUC, resource.PhoneNumber, resource.Email);
    }
}