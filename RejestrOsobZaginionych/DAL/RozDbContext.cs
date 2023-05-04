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
        SeedInitialMissingPeople(builder);
        SeedRoles(builder);
        SeedAdmin(builder);
        base.OnModelCreating(builder);
    }

    public DbSet<MissingPerson> MissingPeople { get; set; }

    private void SeedInitialMissingPeople(ModelBuilder builder)
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
        
        builder.Entity<MissingPerson>().HasData(initialMissingPeople);
    }

    private void SeedRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData
        (
            new IdentityRole() { Id = "cf1e50c9-74fb-4614-b547-ccbde7bd79ba", Name = "User", ConcurrencyStamp = "1", NormalizedName = "USER"},
            new IdentityRole() { Id = "0c51cb7b-0460-4663-98b5-4f4a7e225cf5", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN"}
        );
    }
    
    private void SeedAdmin(ModelBuilder builder)
    {
        var hasher = new PasswordHasher<IdentityUser>();
        builder.Entity<IdentityUser>().HasData
        (
            new IdentityUser()
            {
                Id = "9852271c-4681-4816-885d-69e36175b5d8",
                UserName = "admin@abc.com",
                NormalizedUserName = "ADMIN@ABC.COM",
                PasswordHash = hasher.HashPassword(null, "admin")
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                RoleId = "0c51cb7b-0460-4663-98b5-4f4a7e225cf5",
                UserId = "9852271c-4681-4816-885d-69e36175b5d8"
            }
        );
    }
}