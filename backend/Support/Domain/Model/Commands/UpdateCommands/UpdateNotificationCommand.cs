namespace backend.Support.Domain.Model.Commands;

public record UpdateNotificationCommand(int id, string conductorId, string mensaje, bool leido);