using SendMessageManagement.Domain.Enums;

namespace SendMessageManagement.Application.Interfaces;

public interface ICreateMessageType
{
    string CreateMessage(MessageTypeEnum messageType);
}
