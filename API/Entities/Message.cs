namespace API.Entities;

public class Message
{
    // navigation properties in EF need to be initialised to null so
    // use the null forgiving operator for these

    public int Id { get; set; }
    public int SenderId { get; set; }
    public required string SenderUsername { get; set; }
    public AppUser Sender { get; set; } = null!;
    public int RecipientId { get; set; }
    public required string RecipientUsername { get; set; }
    public AppUser Recipient { get; set; } = null!;
    public required string Content { get; set; }
    public DateTime? DateRead { get; set; }
    public DateTime MessageSent { get; set; } = DateTime.UtcNow;
    public bool SenderDeleted { get; set; }
    public bool RecipientDeleted { get; set; }
}
