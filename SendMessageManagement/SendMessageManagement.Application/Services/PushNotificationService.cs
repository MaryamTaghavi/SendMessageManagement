using SendMessageManagement.Application.Interfaces;
using SendMessageManagement.Domain.DTOs;
using SendMessageManagement.Domain.Entities;

namespace SendMessageManagement.Application.Services;

public class PushNotificationService : ICreateMessageType
{
    public Message CreateMessage()
    {
        return new PushNotificationMessage { Content = "Hello", CreatedAt = DateTime.Now };
    }
}