using System.ComponentModel.DataAnnotations;

public class CommunityMember
{
    [Key]
    public int MemberId { get; set; }
    public int CommunityId { get; set; }
    public int UserId { get; set; }
    public DateTime JoinedAt { get; set; }
}