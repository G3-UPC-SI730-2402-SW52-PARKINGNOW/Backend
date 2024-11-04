using backend.Support.Domain.Model.Aggregates;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class NotificationResourceFromEntityAssembler
{
   public static NotificationResource ToResourceFromEntity(Notification entity)
   {
       return new NotificationResource(entity.Id, entity.ConductorId, entity.Mensaje, entity.Leido);
   }
}