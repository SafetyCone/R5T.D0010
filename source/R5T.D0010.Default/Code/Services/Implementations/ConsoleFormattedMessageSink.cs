using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0010.Default
{[ServiceImplementationMarker]
    public class ConsoleFormattedMessageSink : IFormattedMessageSink,IServiceImplementation
    {
        public Task AddAsync(string formattedMessage)
        {
            Console.WriteLine(formattedMessage);

            return Task.CompletedTask;
        }
    }
}
