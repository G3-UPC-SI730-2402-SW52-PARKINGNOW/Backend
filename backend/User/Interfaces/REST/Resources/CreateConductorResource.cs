using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Interfaces.REST.Resources;

public record CreateConductorResource(ConductorPlaca Placa);