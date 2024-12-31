using System.ComponentModel.DataAnnotations;

public class WorkoutMetric
{
    [Key]
    public int MetricId { get; set; }
    public int WorkoutTypeId { get; set; }
    public string MetricName { get; set; }
    public string MetricUnit { get; set; }
    public bool IsPrimary { get; set; }

    // Navigation properties
    public virtual WorkoutType WorkoutType { get; set; }
    public virtual ICollection<WorkoutDetail> WorkoutDetails { get; set; }
}