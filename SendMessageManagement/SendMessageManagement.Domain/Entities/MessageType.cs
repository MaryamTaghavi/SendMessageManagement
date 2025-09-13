using SendMessageManagement.Domain.Enums;

namespace SendMessageManagement.Domain.Entities;

public class MessageType
{
    public string Name { get; set; }
    public MessageTypeEnum Type { get; set; }
}
