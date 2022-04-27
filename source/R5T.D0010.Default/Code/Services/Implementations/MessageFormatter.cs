using System;
using System.Threading.Tasks;

using R5T.T0001;

using R5T.Magyar.Extensions;using R5T.T0064;


namespace R5T.D0010.Default
{[ServiceImplementationMarker]
    public class MessageFormatter : IMessageFormatter,IServiceImplementation
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
