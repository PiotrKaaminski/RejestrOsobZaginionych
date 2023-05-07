using System.Diagnostics;
using RejestrOsobZaginionych.DAL;
using RejestrOsobZaginionych.DAL.Entities;
using RejestrOsobZaginionych.Models.MissingPerson;

namespace RejestrOsobZaginionych.Services.MissingPerson;

public class AddMissingPersonService
{
    private readonly RozDbContext _dbContext;

    public AddMissingPersonService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddMissingPerson(AddMissingPersonRequest request, string creatorId, IFormFile? image)
    {
        var creator = _dbContext.Users.Find(creatorId);
        Debug.Assert(creator != null, nameof(creator) + " != null");

        var newMissingPerson = new DAL.Entities.MissingPerson();
        newMissingPerson.FirstName = request.FirstName;
        newMissingPerson.LastName = request.LastName;
        newMissingPerson.Age = request.Age;
        newMissingPerson.Male = request.Male;
        newMissingPerson.MissingSince = request.MissingSince;
        newMissingPerson.Location = request.Location;
        newMissingPerson.Creator = creator;
        if (image != null)
        {
            newMissingPerson.ImageId = AddImage(image);
        }
        _dbContext.MissingPeople.Add(newMissingPerson);
        _dbContext.SaveChanges();
    }

    private int AddImage(IFormFile image)
    {
        var personImage = new PersonImage();
        personImage.File = ReadFile(image);
        personImage.Type = image.ContentType;
        var entity = _dbContext.PersonImages.Add(personImage);
        _dbContext.SaveChanges();
        return entity.Entity.Id;
    }
    
    private byte[] ReadFile(IFormFile image)
    {
        var reader = new BinaryReader(image.OpenReadStream());
        return reader.ReadBytes((int)image.Length);
    }
}