using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.User.Infrastructure.Persistence.EFC.Repositories;

public class ConductorRepository(AppDbContext context) : BaseRepository<Conductor>(context), IConductorRepository
{
    private IConductorRepository _conductorRepositoryImplementation;

    public new async Task<Conductor?> FindByPlacaAync(string placa) =>
        await Context.Set<Conductor>().Where(t => t.Placa.placa_vehicular == placa).FirstOrDefaultAsync();
}