namespace backend.User.Domain.Model.ValueObjects;

public record UsuarioPersonalInfo(string fullname, string age, string dni)
{
    public UsuarioPersonalInfo() : this(string.Empty, string.Empty, string.Empty)
    {
        if (fullname == string.Empty || age == string.Empty || dni == string.Empty)
        {
            throw new Exception("Fullname, age and dni can't be empty");
        }
    }
    
    public string getFullInfo => $"{fullname} {age} {dni}";
}