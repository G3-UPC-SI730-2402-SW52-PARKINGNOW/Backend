using backend.User.Domain.Model.ValueObjects;

namespace backend.User.Domain.Model.Aggregates;

public class DuenoDePlayas
{
    public int Id { get; }
    public DuenoInfo DuenoInfo { get; set; }
    public DuenoRUC DuenoRUC { get; set; }

    public DuenoDePlayas()
    {
    }
    
    public DuenoDePlayas(string ruc, string phoneNumber, string email)
    {
        DuenoInfo = new DuenoInfo(phoneNumber, email);
        DuenoRUC = new DuenoRUC(ruc);
    }
}