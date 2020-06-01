using System;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public static class IMessageSinkExtensions
    {
        public static Task AddMessageAsync(this IMessageSink messageSink, DateTime timestampUtc, MessageType messageType, string message)
        {
            var messageObject = Message.New(timestampUtc, messageType, message);

            return messageSink.AddAsync(messageObject);
        }

        public static Task AddErrorMessageAsync(this IMessageSink messageSink, DateTime timestampUtc, string errorMessage)
        {
            var message = Message.NewError(timestampUtc, errorMessage);

            var task = messageSink.AddAsync(message);
            return task;
        }

        public static Task AddOutputMessageAsync(this IMessageSink messageSink, DateTime timestampUtc, string outputMessage)
        {
            var message = Message.NewOutput(timestampUtc, outputMessage);

            var task = messageSink.AddAsync(message);
            return task;
        }
    }
}
