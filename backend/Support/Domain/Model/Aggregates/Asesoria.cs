using backend.Support.Domain.Model.Commands;

namespace backend.Support.Domain.Model.Aggregates;

public class Asesoria
{
    public int Id { get; protected set; }
    public string ClienteId { get; set; }
    public string Asunto { get; set; }
    
    public Asesoria()
    {
    }
    
    public Asesoria(string clienteId, string asunto)
    {
        this.ClienteId = clienteId;
        this.Asunto = asunto;
    }

    public Asesoria(CreateAsesoriaCommand command)
    {
        this.ClienteId = command.clienteId;
        this.Asunto = command.asunto;
    }

    public void UpdateFromCommand(UpdateAsesoriaCommand command)
    {
        this.ClienteId = command.clienteId;
        this.Asunto = command.asunto;
    }
}