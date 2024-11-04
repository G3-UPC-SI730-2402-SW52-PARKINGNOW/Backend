using backend.Support.Domain.Model.Commands;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class CreateNotificationCommandFromResourceAssembler
{
    public static CreateNotificationCommand ToCommandFromResource(CreateNotificationResource resource)
    {
        return new CreateNotificationCommand(resource.conductorId, resource.menasaje, resource.leido);
    }
}