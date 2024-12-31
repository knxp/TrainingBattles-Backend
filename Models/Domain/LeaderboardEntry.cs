using System.ComponentModel.DataAnnotations;

public class LeaderboardEntry
{
    [Key]
    public int EntryId { get; set; }
    public int LeaderboardId { get; set; }
    public int UserId { get; set; }
    public int Rank { get; set; }
    public double Value { get; set; }
}