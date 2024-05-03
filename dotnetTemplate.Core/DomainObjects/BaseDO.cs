namespace dotnetTemplate.Core.DomainObjects;

public abstract record BaseDO
{
    // Properties
    private uint _id = 0;
    public uint Id
    {
        get => _id;
        init
        {
            if (value <= 0)
                throw new Exception("The identifier must be a number superior to 0.");

            _id = value;
        }
    }

    private readonly DateTime _entryDate = DateTime.Now;
    public DateTime EntryDate
    {
        get => _entryDate;
        init
        {
            if (value > DateTime.Now)
                throw new Exception("The entry date and time must be equal or lower to the current.");

            _entryDate = value;
        }
    }

    // Relations
    // Put your relations to other domain objects in this section
}