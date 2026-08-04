using System.ComponentModel.DataAnnotations;

namespace GenshinArtifacts.Api.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(typeof(decimal), "0.01", "79228162514264337593543950335")]
    public decimal Price { get; set; }

    public bool IsActive { get; set; } = true;
}