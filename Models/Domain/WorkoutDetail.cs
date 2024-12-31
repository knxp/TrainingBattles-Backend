using System.ComponentModel.DataAnnotations;

public class WorkoutDetail
{
    [Key]
    public int DetailId { get; set; }
    public int WorkoutId { get; set; }
    public int MetricId { get; set; }
    public double MetricValue { get; set; }

    // Navigation properties
    public virtual Workout Workout { get; set; }
    public virtual WorkoutMetric Metric { get; set; }
}