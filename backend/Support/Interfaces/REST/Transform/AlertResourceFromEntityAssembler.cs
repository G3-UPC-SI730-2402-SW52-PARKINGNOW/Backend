using backend.Support.Domain.Model.Aggregates;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class AlertResourceFromEntityAssembler
{
   public static AlertResource ToResourceFromEntity(Alerts entity)
   {
       return new AlertResource(entity.Id, entity.Mensaje, entity.Activo);
   }
}