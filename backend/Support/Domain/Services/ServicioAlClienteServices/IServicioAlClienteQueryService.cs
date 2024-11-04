using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;

namespace backend.Support.Domain.Services;

public interface IServicioAlClienteQueryService
{
    Task<ServicioAlCliente?> Handle(GetServicioAlClienteByIdQuery query);
    Task<IEnumerable<ServicioAlCliente?>> Handle(GetAllServicioAlClienteQuery query);
}