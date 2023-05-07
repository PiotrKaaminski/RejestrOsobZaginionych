using RejestrOsobZaginionych.DAL;

namespace RejestrOsobZaginionych.Services.Users;

public class DeleteUserService
{
    private readonly RozDbContext _dbContext;

    public DeleteUserService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool Delete(string id)
    {
        var user = _dbContext.Users.Find(id);
        if (user == null)
        {
            return false;
        }

        _dbContext.Users.Remove(user);
        _dbContext.SaveChanges();
        return true;
    }
}