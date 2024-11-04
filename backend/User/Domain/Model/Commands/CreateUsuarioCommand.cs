using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Domain.Model.Commands;

public record CreateUsuarioCommand(string fullname, string age, string dni, EUsuarioRol rol);