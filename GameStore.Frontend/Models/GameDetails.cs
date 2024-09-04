using GameStore.Frontend.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GameStore.Frontend.Models;

public class GameDetails
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required String Name { get; set; }

    [Required(ErrorMessage = "The Genre field is required")]
    [JsonConverter(typeof(StringConverter))]
    public string? GenreId { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set;}

    public DateOnly ReleaseDate { get; set; } 
}
