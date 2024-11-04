namespace backend.Support.Domain.Model.Commands;

public record UpdateServicioAlClienteCommand(int id, string clienteId, string asunto);