using Microsoft.AspNetCore.Identity;

namespace RejestrOsobZaginionych.DAL.Entities;

public class MissingPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool Male { get; set; }
    public DateOnly MissingSince { get; set; }
    public string Location { get; set; }
    public IdentityUser? Creator { get; set; }
    public int? ImageId { get; set; }
}