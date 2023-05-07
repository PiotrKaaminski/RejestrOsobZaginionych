namespace RejestrOsobZaginionych.Models.MissingPerson;

using DAL.Entities;

public record MissingPersonListEntry(
    int Id,
    string FirstName,
    string LastName,
    int Age,
    bool Male,
    DateOnly MissingSince,
    string Location,
    int? ImageId,
    string? ContactEmail,
    string? ContactPhoneNumber)
{
    public static MissingPersonListEntry FromEntity(MissingPerson missingPerson)
    {
        return new MissingPersonListEntry(
            missingPerson.Id,
            missingPerson.FirstName,
            missingPerson.LastName,
            missingPerson.Age,
            missingPerson.Male,
            missingPerson.MissingSince,
            missingPerson.Location,
            missingPerson.ImageId,
            missingPerson.Creator?.Email,
            missingPerson.Creator?.PhoneNumber);
    }
}