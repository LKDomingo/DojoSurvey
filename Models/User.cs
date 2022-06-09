using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;
#pragma warning disable CS8618

public class User
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    public string Language { get; set; }

    [MinLength(21)]
    public string? Comment { get; set; }
}