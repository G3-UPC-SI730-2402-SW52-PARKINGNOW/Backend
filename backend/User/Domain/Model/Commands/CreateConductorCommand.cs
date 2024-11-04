using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Domain.Model.Commands;

public record CreateConductorCommand(ConductorPlaca placa);