namespace RejestrOsobZaginionych.Models.MissingPerson.List;

using DAL.Entities;

public record MissingPersonListEntry(
    string FirstName,
    string LastName,
    int Age,
    DateOnly MissingSince,
    string Location,
    string? ImagePath)
{
    public static MissingPersonListEntry FromEntity(MissingPerson missingPerson)
    {
        return new MissingPersonListEntry(
            missingPerson.FirstName,
            missingPerson.LastName,
            missingPerson.Age,
            missingPerson.MissingSince,
            missingPerson.Location,
            missingPerson.ImagePath);
    }
}