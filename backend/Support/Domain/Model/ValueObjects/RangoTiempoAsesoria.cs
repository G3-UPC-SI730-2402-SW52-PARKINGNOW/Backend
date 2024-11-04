namespace backend.Support.Domain.Model.ValueObjects;

public record RangoTiempoAsesoria(DateTime Inicio, DateTime Fin)
{
    public RangoTiempoAsesoria() : this(DateTime.Now, DateTime.Now)
    {
        if (Inicio == DateTime.Now || Fin == DateTime.Now)
        {
            throw new Exception("Inicio can't be empty");
        }
        if (Inicio > Fin)
        {
            throw new Exception("Inicio can't be greater than Fin");
        }
    }
}