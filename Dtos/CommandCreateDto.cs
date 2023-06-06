using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos;

public class CommandCreateDto
{
    [Required] [MaxLength(250)] string HowTo { get; set; }
    [Required] public string Line { get; set; }
    [Required] public string Platform { get; set; }
}