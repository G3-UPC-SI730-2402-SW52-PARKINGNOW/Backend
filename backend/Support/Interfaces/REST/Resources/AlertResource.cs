using backend.Support.Domain.Model.ValueObjects;

namespace backend.Support.Interfaces.REST.Resources;

public record AlertResource(int id, string mensaje, EEstadoAlerta activo);