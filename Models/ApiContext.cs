using Microsoft.EntityFrameworkCore;

namespace starkiller_api.Models;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
    {
    }

    public DbSet<Character> Characters { get; set; } = null!;
}