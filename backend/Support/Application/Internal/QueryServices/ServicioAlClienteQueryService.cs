using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.QueryServices;

public class ServicioAlClienteQueryService(IServicioAlClienteRepository servicioAlClienteRepository) : IServicioAlClienteQueryService
{
    public async Task<ServicioAlCliente?> Handle(GetServicioAlClienteByIdQuery query)
    {
        return await servicioAlClienteRepository.FindByIdAsync(query.id);
    }

    public async Task<IEnumerable<ServicioAlCliente?>> Handle(GetAllServicioAlClienteQuery query)
    {
        return await servicioAlClienteRepository.ListAsync();
    }
}