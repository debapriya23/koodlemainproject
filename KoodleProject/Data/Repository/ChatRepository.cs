using System;
using Core.Domain.Chats;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class ChatRepository :Repository<Chat>,IChatRepository
    {
        public ChatRepository(KoodleDbContext context)
            : base(context)
        {
            if(context ==null)
                throw new ArgumentNullException(nameof(context));
        }
    }
}