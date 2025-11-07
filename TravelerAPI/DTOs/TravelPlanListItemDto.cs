namespace TravelerAPI.DTOs
{
    public record TravelPlanListItemDto
    (
        Guid Id, 
        string Title, 
        int BudgetEur, 
        int Version, 
        DateTimeOffset UpdatedAt
    );
}
