using System;
using System.Threading.Tasks;


namespace R5T.D0010
{
    public static class IMessageRespositoryExtensions
    {
        public static Task ClearAllAsync(this IMessageRepository messageRepository)
        {
            return messageRepository.ClearAsync(x => true);
        }
    }
}
