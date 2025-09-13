using SendMessageManagement.Application.Interfaces;
using SendMessageManagement.Domain.DTOs;
using SendMessageManagement.Domain.Entities;

namespace SendMessageManagement.Application.Services;

public class EmailService : ICreateMessageType
{
    public Message CreateMessage()
    {
        return new EmailMessage { Content = "Hello", CreatedAt = DateTime.Now, Address = "m.taghavi.ce@gmail.com" };
    }
}
