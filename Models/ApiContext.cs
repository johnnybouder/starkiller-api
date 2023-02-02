using Microsoft.EntityFrameworkCore;

namespace starkiller_api.Models;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Character> Characters { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Character>().HasData(
            new Character { Id = 1, Name = "Darth Vader", Allegeance = "Sith", LightSaber = "Red" },
            new Character { Id = 2, Name = "Darth Sidious", Allegeance = "Sith", LightSaber = "Red" },
            new Character { Id = 3, Name = "Kylo Ren", Allegeance = "Sith", LightSaber = "Red" },
            new Character { Id = 4, Name = "Darth Maul", Allegeance = "Sith", LightSaber = "Red" },
            new Character { Id = 5, Name = "Count Dooku", Allegeance = "Sith", LightSaber = "Red" },
            new Character { Id = 6, Name = "Yoda", Allegeance = "Jedi", LightSaber = "Green" },
            new Character { Id = 7, Name = "Luke Skywalker", Allegeance = "Jedi", LightSaber = "Blue" },
            new Character { Id = 8, Name = "Mace Windu", Allegeance = "Jedi", LightSaber = "Purple" }
        );
    }
}