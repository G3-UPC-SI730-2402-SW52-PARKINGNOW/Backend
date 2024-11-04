using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.User.Infrastructure.Persistence.EFC.Repositories;

public class UsuarioRepository(AppDbContext context) : BaseRepository<Usuario>(context), IUsuarioRepository
{
    public new async Task<Usuario?> FindByIdAsync(int id) =>
        await Context.Set<Usuario>().Where(t => t.Id == id).FirstOrDefaultAsync();
    
    public new async Task<Usuario?> FindByDNIAync(string dni) =>
        await Context.Set<Usuario>().Where(t => t.PersonalInfo.dni == dni).FirstOrDefaultAsync();

    public new async Task<IEnumerable<Usuario>> ListAsync()
    {
        return await Context.Set<Usuario>().ToListAsync();
    }
}