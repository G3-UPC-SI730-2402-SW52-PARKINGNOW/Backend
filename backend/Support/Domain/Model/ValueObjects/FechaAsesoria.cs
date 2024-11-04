namespace backend.Support.Domain.Model.ValueObjects;

public record FechaAsesoria(DateTime Fecha)
{
    public FechaAsesoria() : this(DateTime.Now)
    {
        if (Fecha == DateTime.Now)
        {
            throw new Exception("Fecha can't be empty");
        }
    }
}