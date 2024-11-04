using backend.Support.Domain.Model.ValueObjects;

namespace backend.Support.Domain.Model.Commands;

public record CreateAlertCommand(string mensaje, EEstadoAlerta activo);