using backend.Support.Domain.Model.Commands;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class UpdateAlertCommandFromResourceAssembler
{
    public static UpdateAlertCommand ToCommandFromResource(AlertResource resource)
    {
        return new UpdateAlertCommand(resource.id, resource.mensaje, resource.activo);
    }
}