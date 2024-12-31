using System.ComponentModel.DataAnnotations;

public class Battle
{
    [Key]
    public int BattleId { get; set; }
    public int OrganizerId { get; set; }
    public int OpponentId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string StatToCompare { get; set; }
    public int? WinnerId { get; set; }
    public DateTime CreatedAt { get; set; }
}