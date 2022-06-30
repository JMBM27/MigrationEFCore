namespace ApplicationCore.Entities;

public class Company : BaseEntity
{

    public string Name { get; set; } = string.Empty;

    public bool Active { get; set; }

}
