using backend.Support.Domain.Model.ValueObjects;

namespace backend.Support.Interfaces.REST.Resources;

public record UpdateAlertResource(int id, string mensaje, EEstadoAlerta activo);