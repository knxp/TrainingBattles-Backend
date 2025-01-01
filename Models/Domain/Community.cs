using System.ComponentModel.DataAnnotations;

public class Community
{
    [Key]
    public int CommunityId { get; set; }
    public string CommunityName { get; set; }
    public int OrganizerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Description { get; set; }
}