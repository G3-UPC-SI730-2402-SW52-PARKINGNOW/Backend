using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Repositories;
using backend.Support.Domain.Services;

namespace backend.Support.Application.Internal.QueryServices;

public class AsesoriasQueryService(IAsesoriaRepository asesoriaRepository) : IAsesoriaQueryService
{
    public async Task<Asesoria?> Handle(GetAsesoriaByIdQuery query)
    {
        return await asesoriaRepository.FindByIdAsync(query.id);
    }

    public async Task<IEnumerable<Asesoria?>> Handle(GetAllAsesoriasQuery query)
    {
        return await asesoriaRepository.ListAsync();
    }
}