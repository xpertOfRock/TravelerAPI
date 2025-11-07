namespace TravelerAPI.DTOs
{
    public record TravelPlanDetailsDto(
        Guid Id,
        string Title,
        int BudgetEur,
        int Version,
        DateTimeOffset CreatedAt,
        DateTimeOffset UpdatedAt,
        IReadOnlyList<LocationItemDto> Locations
    );
}
