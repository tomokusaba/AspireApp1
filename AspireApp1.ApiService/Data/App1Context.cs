using Microsoft.EntityFrameworkCore;

namespace AspireApp1.ApiService.Data;

public class App1Context : DbContext
{
    public App1Context(DbContextOptions<App1Context> options)
    : base(options)
    {
    }

    public DbSet<Books> Books { get; set; } = null!;

}
