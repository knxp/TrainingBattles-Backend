using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<WorkoutMetric> WorkoutMetrics { get; set; }
    public DbSet<WorkoutDetail> WorkoutDetails { get; set; }
    public DbSet<WorkoutType> WorkoutTypes { get; set; }
    public DbSet<Entity> Entities { get; set; }
    public DbSet<EntityMembership> EntityMemberships { get; set; }
    public DbSet<Battle> Battles { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupMembership> GroupMemberships { get; set; }
    public DbSet<Community> Communities { get; set; }
    public DbSet<CommunityMember> CommunityMembers { get; set; }
    public DbSet<Leaderboard> Leaderboards { get; set; }
    public DbSet<LeaderboardEntry> LeaderboardEntries { get; set; }
}
