using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.Queries;
using backend.User.Domain.Repositories;
using backend.User.Domain.Services;

namespace backend.User.Application.Internal.QueryServices;

public class ConductorQueryService(IConductorRepository conductorRepository) : IConductorQueryService
{
    public async Task<Conductor?> Handle(GetConductorByPlacaQuery query)
    {
        return await conductorRepository.FindByPlacaAync(query.Placa.ToString());
    }
}