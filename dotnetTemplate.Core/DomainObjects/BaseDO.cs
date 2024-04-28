namespace dotnetTemplate.Core.DomainObjects;

public abstract record BaseDO
{
    private int _id;
    public int Id
    {
        get => _id;
        set
        {
            if (value <= 0)
                throw new Exception("The identifier must be a number superior to 0.");

            _id = value;
        }
    }

    private readonly DateTime _creationDate = DateTime.Now;
    public DateTime CreationDate
    {
        get => _creationDate;
        init
        {
            if (value > DateTime.Now)
                throw new Exception("The creation date and time must be equal or lower to the current.");

            _creationDate = value;
        }
    }
}