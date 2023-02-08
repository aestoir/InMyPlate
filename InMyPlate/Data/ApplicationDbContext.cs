using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InMyPlate.Models;

namespace InMyPlate.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<InMyPlate.Models.Post> Post { get; set; } = default!;
    public DbSet<InMyPlate.Models.Restaurant> Restaurant { get; set; } = default!;
    public DbSet<InMyPlate.Models.City> City { get; set; } = default!;
}

