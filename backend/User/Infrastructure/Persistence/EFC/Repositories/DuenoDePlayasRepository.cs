using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.User.Infrastructure.Persistence.EFC.Repositories;

public class DuenoDePlayasRepository(AppDbContext context) : BaseRepository<DuenoDePlayas>(context), IDuenoDePlayasRepository
{
    public new async Task<DuenoDePlayas?> FindByRUCAsync(string ruc) =>
        await Context.Set<DuenoDePlayas>().Where(t => t.DuenoRUC.RUC == ruc).FirstOrDefaultAsync();
}