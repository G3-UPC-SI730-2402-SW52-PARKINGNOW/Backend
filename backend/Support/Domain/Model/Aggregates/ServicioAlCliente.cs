using backend.Support.Domain.Model.Commands;

namespace backend.Support.Domain.Model.Aggregates;

public class ServicioAlCliente
{
    public int Id { get; protected set; }
    public string ClienteId { get; set; }
    public string Asunto { get; set; }
    
    public ServicioAlCliente()
    {
    }
    
    public ServicioAlCliente(string clienteId, string asunto)
    {
        this.ClienteId = clienteId;
        this.Asunto = asunto;
    }

    public ServicioAlCliente(CreateServicioAlClienteCommand command)
    {
        this.ClienteId = command.clienteId;
        this.Asunto = command.asunto;
    }
}