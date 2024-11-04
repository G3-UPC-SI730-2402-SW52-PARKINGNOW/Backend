using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Interfaces.REST.Resources;

public record CreateUsuarioResource(string Fullname, string Age, string DNI, EUsuarioRol Rol);