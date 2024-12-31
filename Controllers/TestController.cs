using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TestController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: http://localhost:5291/api/test/table/{tableName}
    // Examples:
    // /api/test/table/users
    // /api/test/table/battles
    // /api/test/table/groups
    // /api/test/table/communities
    // /api/test/table/leaderboards
    [HttpGet("table/{tableName}")]
    public async Task<IActionResult> GetTableData(string tableName)
    {
        try
        {


            return tableName.ToLower() switch
            {
                "users" => Ok(await _context.Users.ToListAsync()),
                "battles" => Ok(await _context.Battles.ToListAsync()),
                "groups" => Ok(await _context.Groups.ToListAsync()),
                "groupmemberships" => Ok(await _context.GroupMemberships.ToListAsync()),
                "communities" => Ok(await _context.Communities.ToListAsync()),
                "communitymembers" => Ok(await _context.CommunityMembers.ToListAsync()),
                "leaderboards" => Ok(await _context.Leaderboards.ToListAsync()),
                "leaderboardentries" => Ok(await _context.LeaderboardEntries.ToListAsync()),
                "workouts" => Ok(await _context.Workouts.ToListAsync()),
                "workoutmetrics" => Ok(await _context.WorkoutMetrics.ToListAsync()),
                "workoutdetails" => Ok(await _context.WorkoutDetails.ToListAsync()),
                "workouttypes" => Ok(await _context.WorkoutTypes.ToListAsync()),
                "entities" => Ok(await _context.Entities.ToListAsync()),
                "entitymemberships" => Ok(await _context.EntityMemberships.ToListAsync()),
                _ => NotFound($"Table '{tableName}' not found")
            };

        }
        catch (Exception ex)
        {
            return BadRequest($"Error accessing table {tableName}: {ex.Message}");
        }
    }

    // POST: http://localhost:5291/api/test/user
    [HttpPost("user")]
    public async Task<IActionResult> CreateUser(User user)
    {
        try
        {
            user.CreatedAt = DateTime.UtcNow;  // Set creation time automatically
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTableData), new { tableName = "users" }, user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /* Example POST body in Postman:
    {
        "username": "testuser",
        "email": "test@example.com",
        "firstName": "Test",
        "lastName": "User"
    }
    */
}