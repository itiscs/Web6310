using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tododb;Username=postgres;Password=1");
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;

    }
}
