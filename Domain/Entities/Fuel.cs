using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Fuel : Entity<Guid>
{
    public string? Name { get; set; }
    public virtual ICollection<Model> Models { get; set; }

    public Fuel()
    {
        Models = new List<Model>();
    }

    public Fuel(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }

}
