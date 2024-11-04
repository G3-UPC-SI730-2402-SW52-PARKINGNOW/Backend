namespace backend.Support.Domain.Model.Commands;

public record UpdateAsesoriaCommand(int id, string clienteId, string asunto);