using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    // Looks a bit odd as these are required, but if we do not make the strings optional
    // then the validation error returned looks a bit wierd if we use the 'required' modifier

    [Required] public string Username { get; set; } = string.Empty;

    [Required] public string? KnownAs { get; set; }
    [Required] public string Gender { get; set; } = string.Empty;

    [Required] public DateOnly? DateOfBirth { get; set; } // Note this must be optional or the required validator will not work
    [Required] public string? City { get; set; }
    [Required] public string? Country { get; set; }

    [Required]
    [StringLength(8, MinimumLength = 4)]
    public string Password { get; set; } = string.Empty;
}
