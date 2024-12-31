using System.ComponentModel.DataAnnotations;

public class Leaderboard
{
    [Key]
    public int LeaderboardId { get; set; }
    public int EntityId { get; set; }
    public int MetricId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}