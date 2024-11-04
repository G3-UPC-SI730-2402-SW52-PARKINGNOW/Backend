using backend.Support.Domain.Model.Aggregates;
using backend.User.Domain.Model.Aggregates;
using backend.User.Domain.Model.ValueObjects;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace backend.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
        // Enable Audit Fields Interceptors
        builder.AddCreatedUpdatedInterceptor();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure Usuario entity
        builder.Entity<Usuario>().HasKey(p => p.Id);
        builder.Entity<Usuario>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Usuario>().OwnsOne(p => p.PersonalInfo, personalInfo =>
        {
            personalInfo.Property(p => p.fullname).IsRequired().HasMaxLength(100);
            personalInfo.Property(p => p.age).IsRequired().HasMaxLength(3);
            personalInfo.Property(p => p.dni).IsRequired().HasMaxLength(10);
        });
        builder.Entity<Usuario>().Property(p => p.Rol).IsRequired();

        // Configure Conductor entity
        builder.Entity<Conductor>().HasBaseType<Usuario>();
        builder.Entity<Conductor>().HasKey(p => p.Id);
        builder.Entity<Conductor>().Property(p=> p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Conductor>().Property(p=>p.Placa).IsRequired().HasMaxLength(10);

        // Configure DuenoDePlayas entity
        builder.Entity<DuenoDePlayas>().HasBaseType<Usuario>();
        builder.Entity<DuenoDePlayas>().HasKey(p=>p.Id);
        builder.Entity<DuenoDePlayas>().Property(p=>p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<DuenoDePlayas>().OwnsOne(p => p.DuenoInfo, duenoInfo =>
        {
            duenoInfo.Property(p => p.phoneNumber).IsRequired().HasMaxLength(10);
            duenoInfo.Property(p => p.email).IsRequired().HasMaxLength(50);
        });
        builder.Entity<DuenoDePlayas>().OwnsOne(p => p.DuenoRUC, duenoRUC =>
        {
            duenoRUC.Property(p => p.RUC).IsRequired().HasMaxLength(11);
        });
        
        // Configure Alert entity
        builder.Entity<Alerts>().HasKey(p => p.Id);
        builder.Entity<Alerts>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Alerts>().Property(p => p.Mensaje).IsRequired().HasMaxLength(100);
        builder.Entity<Alerts>().Property(p => p.Activo).IsRequired();
        
        // Configure Asesoria entity
        builder.Entity<Asesoria>().HasKey(p => p.Id);
        builder.Entity<Asesoria>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Asesoria>().Property(p => p.ClienteId).IsRequired().HasMaxLength(10);
        builder.Entity<Asesoria>().Property(p => p.Asunto).IsRequired().HasMaxLength(200);
        
        // Configure Notification entity
        builder.Entity<Notification>().HasKey(p => p.Id);
        builder.Entity<Notification>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Notification>().Property(p => p.ConductorId).IsRequired().HasMaxLength(10);
        builder.Entity<Notification>().Property(p => p.Mensaje).IsRequired().HasMaxLength(200);
        builder.Entity<Notification>().Property(p => p.Leido).IsRequired();
        
        // Configure Servicio al Cliente entity
        builder.Entity<ServicioAlCliente>().HasKey(p => p.Id);
        builder.Entity<ServicioAlCliente>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<ServicioAlCliente>().Property(p => p.ClienteId).IsRequired().HasMaxLength(10);
        builder.Entity<ServicioAlCliente>().Property(p => p.Asunto).IsRequired().HasMaxLength(200);
    }
}