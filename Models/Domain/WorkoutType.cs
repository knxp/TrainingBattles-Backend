using System.ComponentModel.DataAnnotations;

public class WorkoutType
{
    [Key]
    public int WorkoutTypeId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }

    // Navigation properties
    public virtual ICollection<Workout> Workouts { get; set; }
    public virtual ICollection<WorkoutMetric> WorkoutMetrics { get; set; }
}