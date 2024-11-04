namespace backend.Support.Domain.Model.ValueObjects;

public record DescripcionNotificacion(string descripcion)
{
    public DescripcionNotificacion() : this(string.Empty)
    {
        if (descripcion == string.Empty)
        {
            throw new Exception("Descripcion can't be empty");
        }
    }
}