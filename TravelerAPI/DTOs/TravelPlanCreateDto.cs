using System.ComponentModel.DataAnnotations;

namespace TravelerAPI.DTOs
{
    public record TravelPlanCreateDto
    (
        [Required, MaxLength(200)] string Title,
        [Range(0, int.MaxValue)] int BudgetEur
    );   
}
