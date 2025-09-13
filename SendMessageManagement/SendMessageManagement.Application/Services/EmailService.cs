using SendMessageManagement.Application.Interfaces;
using SendMessageManagement.Domain.Enums;

namespace SendMessageManagement.Application.Services;

public class EmailService : ICreateMessageType
{
    public string CreateMessage(MessageTypeEnum messageType)
    {
        throw new NotImplementedException();
    }
}
