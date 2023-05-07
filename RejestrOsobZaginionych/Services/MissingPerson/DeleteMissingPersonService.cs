using RejestrOsobZaginionych.DAL;

namespace RejestrOsobZaginionych.Services.MissingPerson;

public class DeleteMissingPersonService
{
    private readonly RozDbContext _dbContext;

    public DeleteMissingPersonService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool Delete(int id)
    {
        var missingPerson = _dbContext.MissingPeople.Find(id);
        if (missingPerson == null)
        {
            return false;
        }

        if (missingPerson.ImageId.HasValue)
        {
            RemoveImage(missingPerson.ImageId.Value);
        }
        _dbContext.MissingPeople.Remove(missingPerson);
        _dbContext.SaveChanges();
        return true;
    }

    private void RemoveImage(int imageId)
    {
        var entity = _dbContext.PersonImages.Find(imageId);
        _dbContext.PersonImages.Remove(entity);
    }
}