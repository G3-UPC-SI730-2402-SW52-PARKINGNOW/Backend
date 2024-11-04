using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Interfaces.REST.Resources;

public record UsuarioResource(int Id, string Fullname, string Age, string DNI, EUsuarioRol Rol);