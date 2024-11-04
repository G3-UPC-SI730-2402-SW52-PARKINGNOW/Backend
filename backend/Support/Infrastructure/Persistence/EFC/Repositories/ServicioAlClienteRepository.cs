using backend.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend.Shared.Infrastructure.Persistence.EFC.Repositories;
using backend.Support.Domain.Model.Aggregates;
using backend.Support.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Support.Infrastructure.Persistence.EFC.Repositories;

public class ServicioAlClienteRepository(AppDbContext context) : BaseRepository<ServicioAlCliente>(context), IServicioAlClienteRepository
{
    private IServicioAlClienteRepository _servicioAlClienteRepositoryImplementation;
    
    public new async Task<ServicioAlCliente?> FindByIdAsync(int id) =>
        await Context.Set<ServicioAlCliente>().Where(t => t.Id == id).FirstOrDefaultAsync();
}