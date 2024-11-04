using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Model.Queries;

namespace backend.Support.Domain.Services;

public interface IAsesoriaQueryService
{
    Task<Asesoria?> Handle(GetAsesoriaByIdQuery query);
    Task<IEnumerable<Asesoria?>> Handle(GetAllAsesoriasQuery query);
}