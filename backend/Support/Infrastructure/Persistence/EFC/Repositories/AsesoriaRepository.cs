using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Support.Infrastructure.Persistence.EFC.Repositories;

public class AsesoriaRepository(AppDbContext context) : BaseRepository<Asesoria>(context), IAsesoriaRepository
{
    private IAsesoriaRepository _asesoriaRepositoryImplementation;
    
    public new async Task<Asesoria?> FindByIdAsync(int id) =>
        await Context.Set<Asesoria>().Where(t => t.Id == id).FirstOrDefaultAsync();
}