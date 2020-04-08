using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Chats;
using Core.Domain.Messages;

namespace Services.Chats
{
    public interface IChatService
    {
        Task AddChatAsync(Chat chat);
        
        Task<bool> DoesChatExistAsync(string senderId);
        
        Task AddMessageAsync(Message message);
        
        Task<(IEnumerable<Message> messages, bool loadMore)> GetChatMessagesAsync(string senderId, string recipientId,int pageIndex, int pageSize);

        Task MarkAsReadAsync(string chatId);
        
        Task<List<int>> GetUnReadMessageIdsAsync(string chatId);
    }
}