using System.ComponentModel.DataAnnotations;

public class Group
{
    [Key]
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public int OrganizerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Description { get; set; }
}