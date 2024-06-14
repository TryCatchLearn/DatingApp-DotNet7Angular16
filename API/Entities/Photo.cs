using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    // navigation properties in EF need to be initialised to null so
    // use the null forgiving operator for these

    public int Id { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }
    public string? PublicId { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; } = null!;
}