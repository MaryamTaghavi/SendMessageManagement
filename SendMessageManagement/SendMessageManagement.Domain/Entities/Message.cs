namespace SendMessageManagement.Domain.Entities;

public abstract class Message
{
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}
