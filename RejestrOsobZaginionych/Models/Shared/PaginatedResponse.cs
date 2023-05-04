namespace RejestrOsobZaginionych.Models.Common;

public record PaginatedResponse<T>(
    IEnumerable<T> Rows, 
    int Page,
    bool HasMore);