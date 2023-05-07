using Microsoft.EntityFrameworkCore;
using RejestrOsobZaginionych.DAL;
using RejestrOsobZaginionych.DAL.Entities;
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

    public PaginatedResponse<MissingPersonListEntry> GetMissingPersonList(PaginationParameters pagination, bool? male)
    {
        var missingPeople = _dbContext.MissingPeople
            .OrderByDescending(mp => mp.MissingSince)
            .Include(mp => mp.Creator)
            .Skip(pagination.PageSize * pagination.Page)
            .Take(pagination.PageSize)
            .Where(mp => male == null || mp.Male.Equals(male))
            .ToList();

        var count = _dbContext.MissingPeople.Count(mp => male == null || mp.Male.Equals(male));
        var rows = missingPeople.ConvertAll(MissingPersonListEntry.FromEntity);
        var hasMore = (pagination.PageSize * pagination.Page) + rows.Count < count;
        return new (rows, pagination.Page, hasMore);
    }

    public PersonImage GetPersonImage(int id)
    {
        return _dbContext.PersonImages.Find(id);
    }

}