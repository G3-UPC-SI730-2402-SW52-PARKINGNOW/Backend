using backend.Support.Domain.Model.Commands;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class CreateServicioAlClienteCommandFromResourceAssembler
{
    public static CreateServicioAlClienteCommand ToCommandFromResource(CreateServicioAlClienteResource resource)
    {
        return new CreateServicioAlClienteCommand(resource.clienteId, resource.asunto);
    }
}