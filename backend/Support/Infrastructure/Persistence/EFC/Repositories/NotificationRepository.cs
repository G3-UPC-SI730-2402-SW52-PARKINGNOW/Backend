using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Support.Infrastructure.Persistence.EFC.Repositories;

public class NotificationRepository(AppDbContext context) : BaseRepository<Notification>(context), INotificationRepository
{
    private INotificationRepository _notificationRepositoryImplementation;
    
    public new async Task<Notification?> FindNotificationByConductorAsync(string id) =>
        await Context.Set<Notification>().Where(t => t.ConductorId == id).FirstOrDefaultAsync();
}