using backend.Support.Domain.Model.Commands;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class CreateAlertCommandFromResourceAssembler
{
    public static CreateAlertCommand ToCommandFromResource(CreateAlertResource resource)
    {
        return new CreateAlertCommand(resource.mensaje, resource.activo);
    }
}