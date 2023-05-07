using Microsoft.AspNetCore.Identity;
using RejestrOsobZaginionych.DAL;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Models.Users;

namespace RejestrOsobZaginionych.Services.Users;

public class GetUserListService
{
    
    private readonly RozDbContext _dbContext;

    public GetUserListService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public PaginatedResponse<UserListEntry> GetUserList(PaginationParameters pagination)
    {
        var users = _dbContext.Users
            .OrderBy(u => u.Email)
            .Skip(pagination.PageSize * pagination.Page)
            .Take(pagination.PageSize)
            .ToList();
        var count = _dbContext.Users.Count();
        var rows = users.ConvertAll(this.MapToDto);
        var hasMore = (pagination.PageSize * pagination.Page) + rows.Count < count;
        return new(rows, pagination.Page, hasMore);
    }

    private UserListEntry MapToDto(IdentityUser user)
    {
        var userRole = _dbContext.UserRoles.First(ur => ur.UserId.Equals(user.Id));
        var role = _dbContext.Roles.Find(userRole.RoleId);
        var missingPersonCount = _dbContext.MissingPeople.Count(mp => mp.Creator.Id.Equals(user.Id));
        return new(
            user.Id,
            user.UserName,
            role.Name,
            missingPersonCount
        );
    }
}