using Microsoft.AspNetCore.Identity;
using RejestrOsobZaginionych.DAL;

namespace RejestrOsobZaginionych.Services.Users;

public class SwitchUserRoleService
{
    private readonly RozDbContext _dbContext;

    public SwitchUserRoleService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool SwitchRole(string id)
    {
        var user = _dbContext.Users.Find(id);
        if (user == null) return false;

        var currentUserRole = _dbContext.UserRoles.First(ur => ur.UserId.Equals(user.Id));
        var currentRole = _dbContext.Roles.Find(currentUserRole.RoleId);
        IdentityRole newRole;
        if (currentRole.Name.Equals("User"))
        {
            newRole = _dbContext.Roles.First(r => r.Name.Equals("Admin"));
        }
        else
        {
            newRole = _dbContext.Roles.First(r => r.Name.Equals("User"));
        }

        _dbContext.UserRoles.Remove(currentUserRole);
        _dbContext.SaveChanges();
        
        var newUserRole = new IdentityUserRole<string>();
        newUserRole.RoleId = newRole.Id;
        newUserRole.UserId = user.Id;
        _dbContext.UserRoles.Add(newUserRole);
        
        _dbContext.SaveChanges();
        return true;
    }
}