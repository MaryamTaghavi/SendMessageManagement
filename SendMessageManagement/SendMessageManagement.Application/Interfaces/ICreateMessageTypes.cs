using SendMessageManagement.Domain.Entities;

namespace SendMessageManagement.Application.Interfaces;

public interface ICreateMessageTypes
{
    string CreateMessage(MessageType messageType);
}
