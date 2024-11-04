using backend.Support.Domain.Model.Aggregates;
using backend.Support.Interfaces.REST.Resources;

namespace backend.Support.Interfaces.REST.Transform;

public class ServicioAlClienteResourceFromEntityAssembler
{
   public static ServicioAlClienteResource ToResourceFromEntity(ServicioAlCliente entity)
   {
       return new ServicioAlClienteResource(entity.Id, entity.ClienteId, entity.Asunto);
   }
}