using System;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010.Default
{
    public class ConsoleMessageSink : IMessageSink
    {
        private IMessageFormatter MessageFormatter { get; }


        public ConsoleMessageSink(IMessageFormatter messageFormatter)
        {
            this.MessageFormatter = messageFormatter;
        }

        public async Task AddAsync(Message message)
        {
            var formattedMessage = await this.MessageFormatter.FormatAsync(message);

            Console.WriteLine(formattedMessage);
        }
    }
}
