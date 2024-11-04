using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Support.Infrastructure.Persistence.EFC.Repositories;

public class AlertRepository(AppDbContext context) : BaseRepository<Alerts>(context), IAlertRepository
{
    private IAlertRepository _alertRepositoryImplementation;
    
    public new async Task<Alerts?> FindByIdAsync(int id) =>
        await Context.Set<Alerts>().Where(t => t.Id == id).FirstOrDefaultAsync();
}