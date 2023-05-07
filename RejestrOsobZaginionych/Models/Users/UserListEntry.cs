namespace RejestrOsobZaginionych.Models.Users;

public record UserListEntry (
    string Id,
    string UserName,
    string Role,
    int MissingPersonCount
    )
{
    
}