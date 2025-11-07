using System.ComponentModel.DataAnnotations;

namespace TravelerAPI.DTOs
{
    public record TravelPlanUpdateDto
    (
        [Required, MaxLength(200)] string Title,
        [Range(0, int.MaxValue)] int BudgetEur,
        [Range(1, int.MaxValue)] int Version
    );
}
