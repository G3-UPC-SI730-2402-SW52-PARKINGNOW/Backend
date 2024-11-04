namespace backend.User.Domain.Model.ValueObjects;

public record ConductorPlaca(string placa_vehicular)
{
    public ConductorPlaca() : this(string.Empty)
    {
        if (placa_vehicular == string.Empty)
        {
            throw new Exception("Placa vehicular can't be empty");
        }
        
        if (placa_vehicular.Length < 6)
        {
            throw new Exception("Placa vehicular must have at least 6 characters");
        }
    }
}