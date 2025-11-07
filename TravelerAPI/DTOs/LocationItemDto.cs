namespace TravelerAPI.DTOs
{
    public record LocationItemDto
    (
        Guid Id,
        string Name,
        int Order,
        int BudgetEur,
        string? Notes,
        int Version
    );
}
