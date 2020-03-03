using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options)
            : base(options)
        {
        }

        public DbSet<Backend.Models.Workout> Workout { get; set; }
    }
}