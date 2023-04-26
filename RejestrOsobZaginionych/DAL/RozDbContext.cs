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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<MissingPerson>().HasData(getInitialMissingPeople());
        base.OnModelCreating(builder);
    }

    public DbSet<MissingPerson> MissingPeople { get; set; }

    private MissingPerson[] getInitialMissingPeople()
    {
        List<MissingPerson> initialMissingPeople = new List<MissingPerson>();
        var random = new Random();
        for (var i = 0; i < 10; i++)
        {
            initialMissingPeople.Add(new MissingPerson
            {
                Id = i+1,
                FirstName = $"firstName {i}", 
                LastName  = $"lastName {i}",
                Age = random.Next(15, 80),
                MissingSince = new DateOnly(
                    random.Next(2000, 2020),
                    random.Next(1, 12),
                    random.Next(1, 28)
                ),
                Location = "Warszawa",
                ImagePath = null
            });
        }

        return initialMissingPeople.ToArray();
    }
}