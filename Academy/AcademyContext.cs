using Microsoft.EntityFrameworkCore;

public class AcademyContext(DbContextOptions<AcademyContext> options) : DbContext(options)
{
    public DbSet<Academy.Models.Direction> Direction { get; set; } = default!;
}
