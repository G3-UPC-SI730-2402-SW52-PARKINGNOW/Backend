namespace backend.Support.Domain.Model.Commands;

public record CreateNotificationCommand(string conductorId, string mensaje, bool leido);