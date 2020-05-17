using System;
using System.Threading.Tasks;

using R5T.D0001;
using R5T.T0001;


namespace R5T.D0010
{
    public static class IMessageSinkExtensions
    {
        public static async Task AddMessageAsync(this IMessageSink messageSink, INowUtcProvider nowUtcProvider, MessageType messageType, string message)
        {
            var timestampUtc = await nowUtcProvider.GetNowUtcAsync();

            await messageSink.AddMessageAsync(timestampUtc, messageType, message);
        }

        public static Task AddErrorMessageAsync(this IMessageSink messageSink, INowUtcProvider nowUtcProvider, string errorMessage)
        {
            return messageSink.AddMessageAsync(nowUtcProvider, MessageType.Error, errorMessage);
        }

        public static Task AddOutputMessageAsync(this IMessageSink messageSink, INowUtcProvider nowUtcProvider, string outputMessage)
        {
            return messageSink.AddMessageAsync(nowUtcProvider, MessageType.Output, outputMessage);
        }
    }
}
