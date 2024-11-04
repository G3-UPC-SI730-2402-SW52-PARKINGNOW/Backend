using backend.Support.Domain.Model.Aggregates;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class AsesoriaResourceFromEntityAssembler
{
   public static AsesoriaResource ToResourceFromEntity(Asesoria entity)
   {
       return new AsesoriaResource(entity.Id, entity.ClienteId, entity.Asunto);
   }
}