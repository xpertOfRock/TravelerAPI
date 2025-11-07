using System.ComponentModel.DataAnnotations;

namespace TravelerAPI.DTOs
{
    public record LocationCreateDto
    (
        [Required, MaxLength(200)] string Name,
        [Range(0, int.MaxValue)] int BudgetEur,
        [MaxLength(1000)] string? Notes
    );   
}
