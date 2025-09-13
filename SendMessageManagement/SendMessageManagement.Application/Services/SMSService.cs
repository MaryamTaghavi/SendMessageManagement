using SendMessageManagement.Application.Interfaces;
using SendMessageManagement.Domain.DTOs;
using SendMessageManagement.Domain.Entities;

namespace SendMessageManagement.Application.Services;

public class SMSService : ICreateMessageType
{
    public Message CreateMessage()
    {
        return new SMSMessage { Content = "Hello", CreatedAt = DateTime.Now , Number = "09103160108" };
    }
}
