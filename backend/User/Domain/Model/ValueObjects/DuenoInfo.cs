namespace backend.User.Domain.Model.ValueObjects;

public record DuenoInfo(string phoneNumber, string email)
{
    public DuenoInfo() : this(string.Empty, string.Empty)
    {
        if (phoneNumber == string.Empty || email == string.Empty)
        {
            throw new Exception("Phone number and email can't be empty");
        }
    }
}