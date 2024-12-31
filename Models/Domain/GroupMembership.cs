using System.ComponentModel.DataAnnotations;

public class GroupMembership
{
    [Key]
    public int MembershipId { get; set; }
    public int GroupId { get; set; }
    public int UserId { get; set; }
    public DateTime JoinedAt { get; set; }
}