using SendMessageManagement.Application.Interfaces;
using SendMessageManagement.Domain.Enums;

namespace SendMessageManagement.Application.Services;

public class MessageFactory
{
    public static ICreateMessageType GetService(MessageTypeEnum type)
    {
        return type switch
        {
            MessageTypeEnum.SMS => new SMSService(),
            MessageTypeEnum.Email => new EmailService(),
            MessageTypeEnum.PushNotification => new PushService(),
            _ => throw new NotSupportedException()
        };
    }
}
