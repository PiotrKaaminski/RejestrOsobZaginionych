namespace RejestrOsobZaginionych.Models.MissingPerson;

public record AddMissingPersonRequest(
    string FirstName,
    string LastName,
    int Age,
    DateOnly MissingSince,
    string Location);