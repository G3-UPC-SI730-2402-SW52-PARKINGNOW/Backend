using backend.Support.Domain.Model.Commands;
using backend.Support.Domain.Model.ValueObjects;

namespace backend.Support.Domain.Model.Aggregates;

public class Alerts
{
    public int Id { get; protected set; }
    public string Mensaje { get; set; }
    public EEstadoAlerta Activo { get; set; }
    
    public Alerts()
    {
    }
    
    public Alerts(string mensaje, EEstadoAlerta commandActivo)
    {
        this.Mensaje = mensaje;
        this.Activo = EEstadoAlerta.Inactiva;
    }

    public Alerts(CreateAlertCommand command)
    {
        this.Mensaje = command.mensaje;
        this.Activo = command.activo;
    }
    

    public void Active() => Activo = EEstadoAlerta.Activa;
    public void Inactive() => Activo = EEstadoAlerta.Inactiva;
    
}