using System.ComponentModel.DataAnnotations;

public class Entity
{
    [Key]
    public int EntityId { get; set; }
    public string EntityType { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }

    // Navigation properties
    public virtual User CreatedByUser { get; set; }
    public virtual ICollection<EntityMembership> Memberships { get; set; }
    public virtual ICollection<Workout> Workouts { get; set; }
}