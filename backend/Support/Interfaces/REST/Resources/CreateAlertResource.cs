using backend.Support.Domain.Model.ValueObjects;

namespace backend.Support.Interfaces.REST.Resources;

public record CreateAlertResource(string mensaje, EEstadoAlerta activo);