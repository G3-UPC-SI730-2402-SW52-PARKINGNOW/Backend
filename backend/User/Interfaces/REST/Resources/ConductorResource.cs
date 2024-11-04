using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Interfaces.REST.Resources;

public record ConductorResource(int Id, ConductorPlaca Placa);