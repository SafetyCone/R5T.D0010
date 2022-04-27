using System;
using System.Threading.Tasks;

using R5T.T0001;
using R5T.T0064;


namespace R5T.D0010
{
    [ServiceDefinitionMarker]
    public interface IMessageRepository : IMessageSink, IMessageSource, IServiceDefinition
    {
        Task ClearAsync(Func<Message, bool> predicate); // Synchronous predicate ok for now.
    }
}
