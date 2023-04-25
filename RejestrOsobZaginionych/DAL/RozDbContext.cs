using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RejestrOsobZaginionych.DAL.Entities;

namespace RejestrOsobZaginionych.DAL;

using Microsoft.EntityFrameworkCore;

public class RozDbContext : IdentityDbContext<IdentityUser>
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