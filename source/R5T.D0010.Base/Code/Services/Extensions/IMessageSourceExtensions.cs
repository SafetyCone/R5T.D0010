using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public static class IMessageSourceExtensions
    {
        public static Task<IEnumerable<Message>> GetAllMessagesAsync(this IMessageRepository messageRepository)
        {
            return messageRepository.GetMessagesAsync(x => true);
        }

        public static Task< IEnumerable<Message>> GetErrorsAsync(this IMessageRepository messageRepository)
        {
            return messageRepository.GetMessagesAsync(x => x.MessageType == MessageType.Error);
        }
    }
}
