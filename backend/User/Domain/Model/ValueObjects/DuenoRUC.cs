namespace backend.User.Domain.Model.ValueObjects;

public record DuenoRUC(string RUC)
{
    public DuenoRUC() : this(String.Empty)
    {
        if (RUC == string.Empty)
        {
            throw new Exception("El RUC no puede estar vacío");
        }
        
        if (RUC.Length != 11)
        {
            throw new Exception("El RUC debe tener 11 dígitos");
        }
    }
};