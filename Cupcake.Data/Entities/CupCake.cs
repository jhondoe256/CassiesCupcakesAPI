
using System.ComponentModel.DataAnnotations;

public class CupCake
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public CupCakeType Type { get; set; }
}
