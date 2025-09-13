using SendMessageManagement.Domain.Entities;

namespace SendMessageManagement.Application.Interfaces;

public interface ICreateMessageType
{
    Message CreateMessage();
}
