using backend.User.Domain.Model.Aggregates;
using backend.User.Interfaces.REST.Resources;

namespace backend.User.Interfaces.REST.Transform;

public class DuenoDePlayasResourceFromEntityAssembler
{
    public static DuenoDePlayasResource ToResourceFromEntity(DuenoDePlayas entity)
    {
        return new DuenoDePlayasResource(entity.Id, entity.DuenoRUC.RUC, entity.DuenoInfo.phoneNumber, entity.DuenoInfo.email);
    }
}