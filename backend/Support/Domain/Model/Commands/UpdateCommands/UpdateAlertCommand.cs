using backend.Support.Domain.Model.ValueObjects;

namespace backend.Support.Domain.Model.Commands;

public record UpdateAlertCommand(int id, string mensaje, EEstadoAlerta activo);