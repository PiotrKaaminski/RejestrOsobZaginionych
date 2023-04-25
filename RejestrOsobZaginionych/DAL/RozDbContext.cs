using Microsoft.Extensions.Configuration;
using RejestrOsobZaginionych.DAL.Entities;

namespace RejestrOsobZaginionych.DAL.DbContext;

using Microsoft.EntityFrameworkCore;

public class RozDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public RozDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("ROZDatabase"));
    }
    
    public DbSet<MissingPerson> MissingPeople { get; set; }
}