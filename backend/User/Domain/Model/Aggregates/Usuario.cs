using backend.User.Domain.Model.Commands;
using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Domain.Model.Aggregates;

public class Usuario
{
    public int Id { get; }
    public UsuarioPersonalInfo PersonalInfo { get; set; }
    public EUsuarioRol Rol { get; set; }
    
    public Usuario() {}
    
    public Usuario(UsuarioPersonalInfo personalInfo, EUsuarioRol rol)
    {
        PersonalInfo = personalInfo;
        Rol = rol;
    }
    
    public Usuario(string fullname, string age, string dni, EUsuarioRol rol)
    {
        PersonalInfo = new UsuarioPersonalInfo(fullname, age, dni);
        Rol = rol;
    }

    public Usuario(CreateUsuarioCommand command)
    {
        PersonalInfo = new UsuarioPersonalInfo(command.fullname, command.age, command.dni);
        Rol = command.rol;
    }
    
    public string GetFullInfo()
    {
        return PersonalInfo.getFullInfo;
    }
    
    public void SetUserRolConductor() => Rol = EUsuarioRol.Conductor;
    
    public void SetUserRolDuenoDePlayas() => Rol = EUsuarioRol.Duenos_de_playa;
    
    public EUsuarioRol GetUserRol() => Rol;
}