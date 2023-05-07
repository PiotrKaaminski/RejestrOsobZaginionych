namespace RejestrOsobZaginionych.Models.MissingPerson;

public record AddMissingPersonRequest(
    string FirstName,
    string LastName,
    int Age,
    bool Male,
    DateOnly MissingSince,
    string Location);