using System;
using System.Threading.Tasks;


namespace R5T.D0010.Default
{
    public class ConsoleFormattedMessageSink : IFormattedMessageSink
    {
        public Task AddAsync(string formattedMessage)
        {
            Console.WriteLine(formattedMessage);

            return Task.CompletedTask;
        }
    }
}
