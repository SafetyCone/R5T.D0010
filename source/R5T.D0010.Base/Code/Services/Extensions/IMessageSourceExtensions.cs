using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public static class IMessageSourceExtensions
    {
        public static async Task CopyToAsync(this IMessageRepository messageRepository, IMessageSink messageSink)
        {
            var messages = await messageRepository.GetAllMessagesAsync();
            foreach (var message in messages)
            {
                await messageSink.AddAsync(message);
            }
        }

        public static Task<IEnumerable<Message>> GetAllMessagesAsync(this IMessageRepository messageRepository)
        {
            return messageRepository.GetAsync(x => true);
        }

        public static Task<IEnumerable<Message>> GetErrorsAsync(this IMessageRepository messageRepository)
        {
            return messageRepository.GetAsync(x => x.MessageType == MessageType.Error);
        }
    }
}
