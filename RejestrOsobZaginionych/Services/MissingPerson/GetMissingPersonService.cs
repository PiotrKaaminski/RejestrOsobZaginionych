using RejestrOsobZaginionych.DAL;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Models.MissingPerson.List;

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
        var maxPage = Math.Ceiling((double)count / pagination.PageSize);
        var rows = missingPeople.ConvertAll(MissingPersonListEntry.FromEntity);
        return new PaginatedResponse<MissingPersonListEntry>(rows, pagination.Page, (int) maxPage);
    }
    
}