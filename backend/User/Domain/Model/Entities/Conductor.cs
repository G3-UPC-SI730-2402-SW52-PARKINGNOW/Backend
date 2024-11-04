using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Domain.Model.Aggregates;

public class Conductor
{
    public int Id { get; set; }
    public ConductorPlaca Placa { get; set; }
    
    public Conductor() {}
    
    public Conductor(ConductorPlaca placa)
    {
        Placa = placa;
    }
}