namespace API.Entities;

public class Connection
{
    public Connection()
    {

    }

    public Connection(string connectionId, string username)
    {
        ConnectionId = connectionId;
        Username = username;
    }

    public required string ConnectionId { get; set; }
    public required string Username { get; set; }
}
