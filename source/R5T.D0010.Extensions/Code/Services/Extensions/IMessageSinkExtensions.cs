using System;
using System.Threading.Tasks;

using R5T.D0001;


namespace R5T.D0010
{
    public static class IMessageSinkExtensions
    {
        public static async Task AddErrorMessageAsync(this IMessageSink messageSink, INowUtcProvider nowUtcProvider, string errorMessage)
        {
            var timestampUtc = await nowUtcProvider.GetNowUtcAsync();

            await messageSink.AddErrorMessageAsync(timestampUtc, errorMessage);
        }

        public static async Task AddOutputMessageAsync(this IMessageSink messageSink, INowUtcProvider nowUtcProvider, string errorMessage)
        {
            var timestampUtc = await nowUtcProvider.GetNowUtcAsync();

            await messageSink.AddOutputMessageAsync(timestampUtc, errorMessage);
        }
    }
}
