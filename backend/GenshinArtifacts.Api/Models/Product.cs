using System.ComponentModel.DataAnnotations;

namespace GenshinArtifacts.Api.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    /// <remarks>
    /// Opted not to use [Range(0.01, double.MaxValue)] because decimal.MaxValue 
    /// is too large for double.MaxValue.
    /// </remarks>
    [Required]
    [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }

    public bool IsActive { get; set; } = true;
}