using backend.Support.Domain.Model.Commands;

namespace backend.Support.Domain.Model.Aggregates;

public class Notification
{
    public int Id { get; set; }
    public string ConductorId { get; set; }
    public string Mensaje { get; set; }
    public bool Leido { get; set; }
    
    public Notification()
    {
    }
    
    public Notification(string conductorId, string mensaje, bool commandLeido)
    {
        this.ConductorId = conductorId;
        this.Mensaje = mensaje;
        this.Leido = false;
    }

    public Notification(CreateNotificationCommand command)
    {
        this.ConductorId = command.conductorId;
        this.Mensaje = command.mensaje;
        this.Leido = command.leido;
    }
    
    public void MarcarComoLeido()
    {
        this.Leido = true;
    }
}