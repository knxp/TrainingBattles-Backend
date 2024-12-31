using System.ComponentModel.DataAnnotations;

public class Workout
{
    [Key]
    public int WorkoutId { get; set; }
    public int UserId { get; set; }
    public int WorkoutTypeId { get; set; }
    public int? EntityId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int? CaloriesBurned { get; set; }
    public int? AverageHeartRate { get; set; }
    public int? MaxHeartRate { get; set; }
    public string? GPSData { get; set; }

    // Navigation properties
    public virtual User User { get; set; }
    public virtual WorkoutType WorkoutType { get; set; }
    public virtual Entity? Entity { get; set; }
    public virtual ICollection<WorkoutDetail> WorkoutDetails { get; set; }
}