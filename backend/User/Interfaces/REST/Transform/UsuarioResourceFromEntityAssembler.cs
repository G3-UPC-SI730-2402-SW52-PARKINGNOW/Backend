using backend.User.Domain.Model.Aggregates;
using backend.User.Interfaces.REST.Resources;

namespace backend.User.Interfaces.REST.Transform;

public class UsuarioResourceFromEntityAssembler
{
    public static UsuarioResource ToResourceFromEntity(Usuario entity)
    {
        return new UsuarioResource(entity.Id, entity.PersonalInfo.fullname, entity.PersonalInfo.age, entity.PersonalInfo.dni, entity.Rol);
    }
}