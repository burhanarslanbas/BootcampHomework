namespace Core.Entities;

public abstract class BaseEntity<TId>
{
    protected BaseEntity()
    {
        Id = default!;
        CreatedDate = DateTime.UtcNow;
    }
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}