using System;
using System.Threading.Tasks;

using R5T.T0001;

using R5T.Magyar.Extensions;


namespace R5T.D0010.Default
{
    public class MessageFormatter : IMessageFormatter
    {
        #region Static

        public static string FormatMessage(Message message)
        {
            var formattedMessage = $"{message.TimestampUtc.ToYYYYMMDD_HHMMSS_FFF()} - {message.MessageType}:\n{message.Value}";
            return formattedMessage;
        }

        #endregion


        public Task<string> FormatAsync(Message message)
        {
            var formattedMessage = MessageFormatter.FormatMessage(message);
            return Task.FromResult(formattedMessage);
        }
    }
}
