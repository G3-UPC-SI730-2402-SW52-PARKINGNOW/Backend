using backend.User.Domain.Model.Commands;
using backend.User.Interfaces.REST.Resources;

namespace backend.User.Interfaces.REST.Transform;

public static class CreateUsuarioCommandFromResourceAssembler
{
    public static CreateUsuarioCommand ToCommandFromResource(CreateUsuarioResource resource)
    {
        return new CreateUsuarioCommand(resource.Fullname, resource.Age, resource.DNI, resource.Rol);
    }
}