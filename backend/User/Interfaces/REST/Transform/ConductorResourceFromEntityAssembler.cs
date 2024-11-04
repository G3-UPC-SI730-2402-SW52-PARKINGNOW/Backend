using backend.User.Domain.Model.Aggregates;
using backend.User.Interfaces.REST.Resources;

namespace backend.User.Interfaces.REST.Transform;

public class ConductorResourceFromEntityAssembler
{
    public static ConductorResource ToResourceFromEntity(Conductor entity)
    {
        return new ConductorResource(entity.Id, entity.Placa);
    }
}