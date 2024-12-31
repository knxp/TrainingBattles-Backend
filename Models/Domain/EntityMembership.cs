using System.ComponentModel.DataAnnotations;

public class EntityMembership
{
    [Key]
    public int MembershipId { get; set; }
    public int EntityId { get; set; }
    public int UserId { get; set; }
    public string Role { get; set; }
    public DateTime JoinedAt { get; set; }

    // Navigation properties
    public virtual Entity Entity { get; set; }
    public virtual User User { get; set; }
}