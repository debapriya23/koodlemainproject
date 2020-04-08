using System;
using Core.Domain.Messages;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(KoodleDbContext context)
            : base(context)
        {
            if (context == null)
                throw new ArgumentException(nameof(context));
        }
    }
}