using BloggerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggerApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
}
