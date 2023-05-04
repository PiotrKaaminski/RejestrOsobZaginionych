using System.Diagnostics;
using RejestrOsobZaginionych.DAL;
using RejestrOsobZaginionych.Models.MissingPerson;

namespace RejestrOsobZaginionych.Services.MissingPerson;

public class AddMissingPersonService
{
    private readonly RozDbContext _dbContext;

    public AddMissingPersonService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddMissingPerson(AddMissingPersonRequest request, string creatorId)
    {
        var creator = _dbContext.Users.Find(creatorId);
        Debug.Assert(creator != null, nameof(creator) + " != null");

        var newMissingPerson = new DAL.Entities.MissingPerson();
        newMissingPerson.FirstName = request.FirstName;
        newMissingPerson.LastName = request.LastName;
        newMissingPerson.Age = request.Age;
        newMissingPerson.MissingSince = request.MissingSince;
        newMissingPerson.Location = request.Location;

        newMissingPerson.Creator = creator;

        _dbContext.MissingPeople.Add(newMissingPerson);
        _dbContext.SaveChanges();

    }
}