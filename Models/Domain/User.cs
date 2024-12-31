using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? AvatarUrl { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation properties
    public virtual ICollection<Workout>? Workouts { get; set; }
    public virtual ICollection<Entity>? CreatedEntities { get; set; }
    public virtual ICollection<EntityMembership>? EntityMemberships { get; set; }
}