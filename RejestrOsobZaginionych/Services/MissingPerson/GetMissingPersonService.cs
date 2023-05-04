using RejestrOsobZaginionych.DAL;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Models.MissingPerson;

namespace RejestrOsobZaginionych.Services.MissingPerson;

public class GetMissingPersonService
{

    private readonly RozDbContext _dbContext;

    public GetMissingPersonService(RozDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public PaginatedResponse<MissingPersonListEntry> GetMissingPersonList(PaginationParameters pagination)
    {
        var missingPeople = _dbContext.MissingPeople
            .OrderByDescending(mp => mp.MissingSince)
            .Skip(pagination.PageSize * pagination.Page)
            .Take(pagination.PageSize)
            .ToList();
        var count = _dbContext.MissingPeople.Count();
        var rows = missingPeople.ConvertAll(MissingPersonListEntry.FromEntity);
        var hasMore = (pagination.PageSize * pagination.Page) + rows.Count < count;
        return new PaginatedResponse<MissingPersonListEntry>(rows, pagination.Page, hasMore);
    }
    
}